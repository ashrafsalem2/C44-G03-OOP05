using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment.Q01
{
    internal class Circle : ICircle
    {
        public decimal Area 
        { 
            get;
            set;
        }

        public Circle(decimal R)
        {
            Area = 2 * 3.14M * R;
        }

        public void DisplayShapeInfo()
        {
            Console.WriteLine($"Circle Area: {Area}");
        }
    }
}
