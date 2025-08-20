using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training._06._01_NewFunctionality
{
    class ObjectDepartment
    {
        public string Name { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}
