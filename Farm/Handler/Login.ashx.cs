using System;
using System.Collections;
using System.Collections.Generic;
using System.Web;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Web.SessionState;
using  Farm;
using System.Reflection;


namespace HST.Handler
{
    /// <summary>
    /// Login 的摘要说明
    /// </summary>
    public class Login : IHttpHandler, IRequiresSessionState 
    {

        public void ProcessRequest(HttpContext context)
        {
            string myPsw = context.Request.Params["psw"];
            context.Session["username"]=  context.Request.Params["username"]??"unknow";
            string actionCode = HttpContext.Current.Request["action"].Substring(4);
            string interfaceType = HttpContext.Current.Request["action"].Substring(0,4);
            sys_action myAction = ConnectionManager.db.SingleOrDefault<sys_action>("WHERE ActionCode=@0", actionCode);
            if (interfaceType.ToLower() == "save")
            {
                GetSaveJson(context, myAction.TableName, myAction.IdField);
            }else
            {
                string myValue = context.Request.Params["id"] ?? "0";
                GetJson(context, myAction.TableName, interfaceType, myAction.IdField, myValue);
            }

        }

        private void GetJson(HttpContext context, string tableName,string interfaceType,string idField,string idValue)
        {
            string jsonStr = "";
            switch (interfaceType)
            {
                case "grid":
                    string mySql = @"select * from " + tableName;
                    if (context.Request.Params["fieldName"]!=null) {
                        mySql+= " where " + context.Request.Params["fieldName"] + "="+ context.Request.Params["fieldValue"];
                    }
                     var resultGrid = ConnectionManager.db.Page<dynamic>(1, 20000, mySql);
                   Hashtable ht = new Hashtable(); //file创建一个Hashtable实例
                    ht.Add("total", resultGrid.TotalItems);//添加keyvalue键值对
                    ht.Add("rows", resultGrid.Items);//添加keyvalue键值对
                     jsonStr = JsonConvert.SerializeObject(ht);
                     break;
                case "tree":
                    var resultTree = ConnectionManager.db.Query<dynamic>( @"select * from " + tableName);
                    jsonStr = JsonConvert.SerializeObject(resultTree);
                     break;
                case "form":
                    var resultForm = ConnectionManager.db.SingleOrDefault<dynamic>(
                        @"select  * from " + tableName+" where "+ idField +"=@0", idValue);
                    jsonStr = JsonConvert.SerializeObject(resultForm);
                     break;
                default:
                     break;
            }
            context.Response.Write(jsonStr);
        }


        private void HandleDBOperation(string tableName, JObject record, string sqlType, string idField,string userName="")
        {
            record["UpdateDate"] = DateTime.Now.ToString("O");
            record["UpdatePerson"] = userName;
            if (sqlType == "delete") record["IsDel"] = 1;
   
            if (sqlType=="insert")
            { 
                record["CreateDate"] = DateTime.Now.ToString("O");
                record["CreatePerson"] = userName;
            }
            else
            {
                record.Remove("CreateDate");
                record.Remove("CreatePerson");
            }
            var myObj = CreateInstance(tableName);
            foreach (KeyValuePair<string, JToken> attr in record)
            {
                PropertyInfo prop = myObj.GetType().GetProperty(attr.Key, BindingFlags.Public | BindingFlags.Instance);
                if (null != prop && prop.CanWrite)
                {
                    prop.SetValue(myObj, Convert.ChangeType(attr.Value, prop.PropertyType), null);
                }

            }
            if (sqlType == "insert") { 
                 ConnectionManager.db.Insert(tableName, idField,true, myObj); }
            else
            {
                int rowsAffected = ConnectionManager.db.Update(tableName, idField, myObj);
            };
        }
        private void GetSaveJson(HttpContext context, String tableName,String idField)
        {   
            string userName = context.Session["username"].ToString()??"unknow";
            Hashtable ht = new Hashtable();
            ht.Add("update", "updated"); 
            ht.Add("insert", "inserted");
            ht.Add("delete", "deleted");
            foreach (DictionaryEntry item in ht)
            {
                object recordsObj=HttpContext.Current.Request[item.Value.ToString()];
                if (recordsObj != null)
                {
                    JArray recordArray = (JArray)JsonConvert.DeserializeObject(recordsObj.ToString());//把json字符串转换成对象
                    if (recordArray != null && recordArray.Count > 0)
                        foreach (JObject record in recordArray)
                            HandleDBOperation(tableName, record, item.Key.ToString(), idField, userName);
                }
            }
           string jsonStr = JsonConvert.SerializeObject("OK");
           context.Response.Write(jsonStr);
        }
      


        public object CreateInstance(string type)
        {
            var objType = Type.GetType("Farm."+type);
            return System.Activator.CreateInstance(objType);
        }
        private  PropertyInfo[] GetpropertyInfoArray(string type)
        {
            Type mytype = Type.GetType("Farm.Entity." + type);
            object obj = Activator.CreateInstance(mytype);
            return mytype.GetProperties();
        }  
        public bool IsReusable
        {
            get
            {
                return false;
            }
        }
    }
}

     