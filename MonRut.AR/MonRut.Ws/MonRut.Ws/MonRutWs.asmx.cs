using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using Castle.ActiveRecord;
using Castle.ActiveRecord.Framework.Config;
using MonRut.Domain;
using System.Diagnostics;

namespace MonRut.Ws
{
    /// <summary>
    /// Summary description for MonRutWs
    /// </summary>
    [WebService(Namespace = "http://monrut.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class MonRutWs : System.Web.Services.WebService
    {

 

        [WebMethod]
        public string HelloWorld()
        {
            return "Hello World";
        }

        [WebMethod]
        public bool AddRoute(string name)
        {
            bool isCreated = false;
            Route r = new Route();
            r.Name = name;

            try
            {
                r.SaveAndFlush();
                isCreated = true;
            }
            catch(Exception ex)
            {
                EventLog el = new EventLog();
                el.Source = "MonRutWs web service";
                el.WriteEntry(ex.Message);
            }

            return isCreated;
        }
    }
}
;