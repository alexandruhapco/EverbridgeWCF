using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;
using EverbridgeWCF.Data;

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