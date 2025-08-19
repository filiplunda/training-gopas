using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training._02._03_VirtualMethods
{
    class VirtualCat: VirtualAnimal
    {
        public override string Sound()
        {
            return "meow-meow";
        }

        /*new public string Sound()
        {
            return "meow-meow";
        }*/
    }
}
