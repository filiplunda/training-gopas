using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training._10._02_Attributes
{
    [AttributeUsage(AttributeTargets.Property)]
    class ValidatorAttribute : Attribute
    {
        public int MaxLenght { get; set; }
    }
}
