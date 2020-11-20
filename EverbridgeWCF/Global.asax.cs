using Castle.Facilities.WcfIntegration;
using Castle.Windsor;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;

namespace EverbridgeWCF {
    public class Global : System.Web.HttpApplication {

        static IWindsorContainer container;

        protected void Application_Start(object sender, EventArgs e) {
            container = new WindsorContainer();
            container.AddFacility<WcfFacility>();
            container.Install(new WindsorInstaller());

            Database.SetInitializer(new DoorDBInitializer());
        }
  
    }
}