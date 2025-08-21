using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training._07._02_AnonymousTypes
{
    class AnonymousEmployee
    {
        int _id;
        public string Name { get; set; }

        public string ID => "EMP" + _id;

        public AnonymousEmployee(int id, string name    )
        {
            _id = id;
            Name = name;
        }

        //public override string ToString() => string.Format("[{0}] {1}", this.ID, this.Name);
        public override string ToString() => $"[{this.ID}] {this.Name}";

    }
}
