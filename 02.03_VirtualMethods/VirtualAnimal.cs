using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training._02._03_VirtualMethods
{
    class VirtualAnimal: Animal
    {
        new public virtual string Sound()
        {
            return base.Sound();
        }
    }
}
