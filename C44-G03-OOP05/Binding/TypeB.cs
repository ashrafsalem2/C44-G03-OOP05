using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C44_G03_OOP05.Binding
{
    internal class TypeB : TypeA
    {
        public int B { get; set; }

        public TypeB(int _A, int _B) : base(_A)
        {
            B = _B;
        }

        // Apply Method Overrideing 'new' in Func01
        public new void Func01() 
        {
            Console.WriteLine("Child Class");
        }

        // Apply Method Overriding 'override' in Func02
        // Method itself
        //      Must Be Public 
        //      Must Be Virtual

        public override void Func02()
        {
            Console.WriteLine($"Type A : {A}, Type B : {B}");
        }
    }
}
 