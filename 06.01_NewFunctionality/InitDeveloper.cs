using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training._06._01_NewFunctionality
{
    class InitDeveloper
    {
        public InitDeveloper()
        {
        }

        //public string FirstName { get; private set; }

        //public string LastName { get; private set; }

        public string FirstName { get; init; } = "James";

        public string LastName { get; init; } = "Jameson";
    }
}
