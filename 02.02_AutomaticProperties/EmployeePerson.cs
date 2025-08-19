using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02._02_AutomaticProperties
{
    class EmployeePerson: Person
    {
        public override string LastName
        {
            get
            {
                return base.LastName.ToUpper();
            }
            set
            {
                base.LastName = value;
            }
        }

        public override string FirstName
        {
            get
            {
                return base.FirstName;
            }
            protected set
            {
                base.FirstName = value;
            }
        }
    }
}
