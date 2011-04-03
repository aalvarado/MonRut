using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;
using Castle.ActiveRecord;
using Castle.ActiveRecord.Framework.Config;
using MonRut.Domain;
using System.Diagnostics;

namespace MonRut.Ws
{
    public class Global : System.Web.HttpApplication
    {

        protected void Application_Start(object sender, EventArgs e)
        {
            try
            {
                
                XmlConfigurationSource src = new XmlConfigurationSource(Server.MapPath("~/arconfig.xml"));
                ActiveRecordStarter.Initialize(src,
                                       typeof(Bus),
                                       typeof(Driver),
                                       typeof(Route),
                                       typeof(Station)
                                       );

            }
            catch (Exception ex)
            {
                // Console.WriteLine("excepcion" + ex.Message);
                EventLog el = new EventLog();
                el.Source = "Application";
                el.WriteEntry(ex.Message);

            }
        }

        protected void Session_Start(object sender, EventArgs e)
        {

        }

        protected void Application_BeginRequest(object sender, EventArgs e)
        {

        }

        protected void Application_AuthenticateRequest(object sender, EventArgs e)
        {

        }

        protected void Application_Error(object sender, EventArgs e)
        {

        }

        protected void Session_End(object sender, EventArgs e)
        {

        }

        protected void Application_End(object sender, EventArgs e)
        {

        }
    }
}