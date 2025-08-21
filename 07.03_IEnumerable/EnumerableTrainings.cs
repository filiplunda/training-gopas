using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training._07._03_IEnumerable
{
    class EnumerableTrainings: IEnumerable<EnumerableTraining>
    {
        private List<EnumerableTraining> training = new List<EnumerableTraining>
        {
            new EnumerableTraining("Programming C"),
            new EnumerableTraining("ASP.NET Security"),
            new EnumerableTraining("ASP.NET MVC"),
            new EnumerableTraining("Programming Java"),

        }; 

        public IEnumerator<EnumerableTraining> GetEnumerator()
        {
            return new TrainingEnumerator(this.training);
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
