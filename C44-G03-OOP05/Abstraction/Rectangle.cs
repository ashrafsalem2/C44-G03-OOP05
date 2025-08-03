using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C44_G03_OOP05.Abstraction
{
    internal class Rectangle : BaseArea
    {
        public override decimal Perimeter  // Goes To | Return
            => (Dim01 + Dim02) * 2;
    }
}
