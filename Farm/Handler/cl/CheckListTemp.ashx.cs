using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.SessionState;
using Newtonsoft.Json;

namespace HST.Handler.CheckListTemp
{
    /// <summary>
    /// CheckListTemp 的摘要说明
    /// </summary>
    public class CheckListTemp : IHttpHandler, IRequiresSessionState
    {

        public void ProcessRequest(HttpContext context)
        {
            GetCheckListTemplate(context, HttpContext.Current.Request["action"]);
        }

        private void GetCheckListTemplate(HttpContext context, string p)
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