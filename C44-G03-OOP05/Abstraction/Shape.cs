using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C44_G03_OOP05.Abstraction
{
    internal abstract class Shape
    {
        public decimal Dim01 { get; set; }
        public decimal Dim02 { get; set; }
        
        // Abstract Method : Signature
        public abstract decimal CalcArea();

        public abstract decimal Perimeter 
        {
            get;
        }
    }
}
