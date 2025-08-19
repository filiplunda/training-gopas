using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02._02_AutomaticProperties
{
    class Person
    {
        /*private string _firstName;

        private string _lastName;

        public string FirstName
        {
            get { return _firstName; }
            set { _firstName = value; }
        }

        public string LastName
        {
            get { return _lastName; }
            set { _lastName = value; }
        }*/

        public virtual string FirstName { get; protected set; }

        public virtual string LastName { get; set; }
    }
}
