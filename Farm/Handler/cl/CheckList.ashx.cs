using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.SessionState;
using Newtonsoft.Json;

namespace HST.Handler.cl
{
    /// <summary>
    /// CheckList 的摘要说明
    /// </summary>
    public class CheckList : IHttpHandler, IRequiresSessionState
    {

        public void ProcessRequest(HttpContext context)
        {
            

                    GetCheckListJson(context,HttpContext.Current.Request["action"]);

        }

        private void GetCheckListJson(HttpContext context, string p)
        {
            throw new NotImplementedException();
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