using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training._02._03_VirtualMethods
{
    class VirtualDog: VirtualAnimal
    {
        public override string Sound()
        {
            return "woof-woof";
        }

        /*new public string Sound()
        {
            return "woof-woof";
        }*/
    }
}
