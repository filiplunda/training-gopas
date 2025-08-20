using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training._06._01_NewFunctionality
{
    class ObjectEmployee
    {
        private int id;

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public ObjectDepartment Department { get; set; }


        public override string ToString()
        {
            return string.Format("[{0}] {1} {2} {3}", id, FirstName, LastName, Department);
        }

        public ObjectEmployee(int id)
        {
            this.id = id;
        }
    }
}
