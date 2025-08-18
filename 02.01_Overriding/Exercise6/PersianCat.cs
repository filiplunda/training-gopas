using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02._01_Overriding.Exercise6
{
    class PersianCat: Cat
    {
        public override string MakeSound()
        {
            //return "Meow Meow";
            return base.MakeSound() + " " + base.MakeSound();

        }
    }
}
