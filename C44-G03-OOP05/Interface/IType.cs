using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C44_G03_OOP05.Interface
{
    // Developer One
    internal interface IType
    {
        // 1. Signature For Property
        public int MyProperty { get; set; }

        // 2. Signature For Method
        public void NyNethod();

        // 2. Default implement Method
        public void Print() 
        {
            Console.WriteLine("Hello From Interface IType");
        }
    }
}
