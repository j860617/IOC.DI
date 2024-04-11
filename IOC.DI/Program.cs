using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unity;
using Unity.Lifetime;

namespace IOC.DI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IUnityContainer container = new UnityContainer();

            container.RegisterType<IPhone, AndroidPhone>();

            container.RegisterType<AbstractPad, ApplePad>();

            container.RegisterType<ApplePad, ApplePadChild>();

            container.RegisterType<AbstractPad, ApplePad>("child");

            container.RegisterType<AbstractPad, ApplePadChild>("grandchild");

            IPhone phone = container.Resolve<IPhone>();

            var childPad = container.Resolve<AbstractPad>("child");

            var grandchildPad = container.Resolve<AbstractPad>("grandchild");

            container.RegisterType<IPhone, ApplePhone>();

            container.RegisterType<IHeadPhone, HeadPhone>();

            container.RegisterType<IMicroPhone, MicroPhone>();

            container.RegisterType<IPower, Power>();

            var applePhone = container.Resolve<IPhone>();

            container.RegisterType<IPhone, ApplePhone>(new ContainerControlledLifetimeManager()); //單例
            
            container.RegisterType<IPhone, ApplePhone>(new PerThreadLifetimeManager()); //線呈單例
        }
    }
}
