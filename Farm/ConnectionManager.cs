using System;
using System.Collections.Generic;
using System.Web;

using System.Text;
using System.Collections;
using Newtonsoft.Json;
using System.Web.SessionState;
using HST;

//namespace AppCode
//{
    public class ConnectionManager
    {
        private ConnectionManager()
        {
        }
        public static PetaPoco.Database db = new PetaPoco.Database("Sys"); 

    
    }
//}