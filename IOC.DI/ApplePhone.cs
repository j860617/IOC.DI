using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unity;

namespace IOC.DI
{
    public class ApplePhone : IPhone
    {
        [Dependency]
        public IMicroPhone MicroPhone { get; set; }
        
        public IHeadPhone HeadPhone { get; set; }

        public IPower Power { get; set; }

        public ApplePhone()
        {
            
        }

        [InjectionConstructor] //默認找參數最多的
        public ApplePhone(IHeadPhone headPhone)
        {
            HeadPhone = headPhone;
        }

        public void Call()
        {
        }

        [InjectionMethod] //不好，破壞封裝
        public void Create(IPower power)
        {
            Power = power;
        }
    }
}
