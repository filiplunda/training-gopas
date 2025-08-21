using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training._08._01_PatternMatching
{
    class MatchingCat: MatchingAnimal
    {
        public void Meow()
        {
            Console.WriteLine("The cat is meowing");
        }

        public string Color { get; set; }
    }
}
