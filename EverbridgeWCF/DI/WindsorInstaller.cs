using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;
using EverbridgeWCF.Data;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace EverbridgeWCF {
    public class WindsorInstaller : IWindsorInstaller {
        public void Install(IWindsorContainer container, IConfigurationStore store) {
            container.Register(
                Component.For<IDoorService, DoorService>(),
                Component.For<IDoorDAO, DoorDAO>(),
                Component.For<DoorContext>().LifestylePerThread());
        }
    }
}