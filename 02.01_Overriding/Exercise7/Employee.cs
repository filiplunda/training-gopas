using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02._01_Overriding.Exercise7
{
    class Employee: object
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }


        public Employee(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public override string ToString()
        {
            return string.Format("{0} {1}", this.FirstName, this.LastName);
        }

        public override bool Equals(object obj)
        {
            Employee? temp = obj as Employee;
            if(temp == null)
            {
                return false;
            }

            return ((this.FirstName == temp.FirstName) && (this.LastName == temp.LastName));
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(FirstName, LastName);
        }
    }
}
