using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C44_G03_OOP05.Abstraction
{
    internal class Circle : Shape
    {
        public Circle(Decimal R)
        {
            Dim01 = Dim02=  R;
        }

        public override decimal Perimeter
            => 2 * 3.14M * Dim01;

        public override decimal CalcArea()
        {
            return 3.14M * Dim01 * Dim02;
        }
    }
}
