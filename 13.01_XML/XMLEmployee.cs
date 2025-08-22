using System.Xml.Serialization;

namespace Training._13._01_XML
{
    public class XMLEmployee
    {
        private int id { get; set; }

        [XmlElement(ElementName = "FName")]
        public string FirstName { get; set; }

        [XmlElement(ElementName = "LName")]
        public string LastName { get; set; }

        public readonly decimal Salary;

        [XmlIgnore()]
        public DateTime TimeStamp { get; private set; }

        public XMLDepartment Department { get; set; }

        //public XMLEmployee(int id, string firstName, string lastName, decimal salary, int departmentId, string departmentName)
        public XMLEmployee(int id, string firstName, string lastName, decimal salary, int departmentId, string departmentName): this()
        {
            this.id = id;
            FirstName = firstName;
            LastName = lastName;
            Salary = salary;
            this.TimeStamp = DateTime.Now;
            this.Department = new XMLDepartment(departmentId, departmentName);
        }

        public override string ToString()
        {
            return $"Id: {id}, Name: {FirstName} {LastName}, Salary: {Salary}, Department: {Department} [{TimeStamp.ToLongTimeString()}] ";
        }

        public XMLEmployee()
        {

        }
    }
}
