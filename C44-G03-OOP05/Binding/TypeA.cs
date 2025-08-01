using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace C44_G03_OOP05.Binding
{
    internal class TypeA
    {
        public int A { get; set; }

        public TypeA(int _A)
        {
            A = _A;
        }

        public void Func01() 
        {
            Console.WriteLine("Parent Class");
        }

        public virtual void Func02() 
        {
            Console.WriteLine($"Type A = {A}");
        }
    }
}
