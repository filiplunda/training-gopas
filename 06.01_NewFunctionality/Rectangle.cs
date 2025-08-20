using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training._06._01_NewFunctionality
{
    class Rectangle
    {
        double a, b;

        public Rectangle(double a, double b)
        {
            this.a = a;
            this.b = b;
        }

        public void Stats(out double width, out double height, out double perimeter, out double area)
        {
            width = this.a;
            height = this.b;
            perimeter = 2 * (this.a + this.b);
            area = this.a * this.b;
        }

        public (double width, double height, double perimeter, double area) GetStats()
        {
            return (this.a, this.b, 2 * (this.a + this.b), this.a * this.b);
        }

        public void Deconstruct(out double width, out double height)
        {
            width = this.a;
            height = this.b;
        }

        public void Deconstruct(out double width, out double height, out double perimeter, out double area)
        {
            width = this.a;
            height = this.b;
            perimeter = 2 * (this.a + this.b);
            area = this.a * this.b;
        }
    }
}
