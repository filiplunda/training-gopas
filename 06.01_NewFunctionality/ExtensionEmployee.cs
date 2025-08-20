using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training._06._01_NewFunctionality
{
    class ExtensionEmployee
    {
        private int id;

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public override string ToString()
        {
            return $"[{id}] {FirstName} {LastName}";
        }

        public ExtensionEmployee(int id, string firstName, string lastName)
        {
            this.id = id;
            FirstName = firstName;
            LastName = lastName;
        }
    }
}
