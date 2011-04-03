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
        public string CreateRoute(string name)
        {
            string msg = "";
            Route r = new Route();
            r.Name = name;

            try
            {
                r.SaveAndFlush();
                msg = "se creo la ruta";
            }
            catch(Exception ex)
            {
                msg = ex.Message;
            }


            return msg;
        }
    }
}
