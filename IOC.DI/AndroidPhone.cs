using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IOC.DI
{
    internal class AndroidPhone : IPhone
    {
        public void Call()
        {

        }
    }

    public interface IPhone
    {
        void Call();
    }
}
