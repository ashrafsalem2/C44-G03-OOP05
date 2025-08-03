using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C44_G03_OOP05.ExampleTwoIO
{

    internal class Airplane : Vehicle, IMoveOnGround, IMoveOnAir
    {
        // implement Interface Implicitly
        public void Backward()
        {
            Console.WriteLine("Airplane Moving Backword");
        }

        public void Forward()
        {
            Console.WriteLine("Airplane Moving Forward");
        }

        public void Left()
        {
            Console.WriteLine("Airplane Moving Left");
        }

        public void Right()
        {
            Console.WriteLine("Airplane Moving Right");
        }

    }
}
