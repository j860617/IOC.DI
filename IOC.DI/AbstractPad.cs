using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IOC.DI
{
    public abstract class AbstractPad
    {
    }

    public class ApplePad : AbstractPad
    {
    }
    
    public class ApplePadChild : ApplePad
    {
    }
}
