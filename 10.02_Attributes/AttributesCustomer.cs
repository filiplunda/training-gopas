using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training._10._02_Attributes
{
    [DebuggerDisplay("FirstName = {FirstName}, LastName = {LastName}")]
    [AliasAttribute("Client")]
    class AttributesCustomer
    {
        [AliasAttribute("CustomerId")]
        public int Id { get; set; }

        [AliasAttribute("FName")]
        [ValidatorAttribute(MaxLenght = 20)]
        public string FirstName { get; set; }

        [AliasAttribute("LName")]
        public string LastName { get; set; }

        [Obsolete("This method is obsolete, use GetFulllName() instead", true)]
        public string GetName()
        {
            return this.FirstName + " " + LastName;
        }

        public string GetFullName()
        {
            return this.FirstName + " " + LastName;
        }
    }
}
