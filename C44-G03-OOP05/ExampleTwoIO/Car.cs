using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C44_G03_OOP05.ExampleTwoIO
{
    internal class Car : Vehicle, IMoveOnGround
    {
        public void Backward()
        {
            Console.WriteLine("Car Moving Backword");
        }

        public void Forward()
        {
            Console.WriteLine("Car Moving Forward");
        }

        public void Left()
        {
            Console.WriteLine("Car Moving Left");
        }

        public void Right()
        {
            Console.WriteLine("Car Moving Right");
        }
    }
}
