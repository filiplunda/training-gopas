using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training._13._01_XML
{
    public class XMLDepartment
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public XMLDepartment(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public override string ToString()
        {
            return $"Id: {Id}, Name: {Name}";
        }

        public XMLDepartment()
        {

        }
    }
}
