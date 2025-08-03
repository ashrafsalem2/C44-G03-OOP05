using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C44_G03_OOP05.Interface
{
    // : Between Class and Interface => Implement
    // : Between Classes => Inhertance
    internal class TypeIO : IType
    {
        public int MyProperty
        {
            get;
            set;
        }

        public void NyNethod()
        {
            Console.WriteLine("Hello From Class Type");
        }
    }
}
