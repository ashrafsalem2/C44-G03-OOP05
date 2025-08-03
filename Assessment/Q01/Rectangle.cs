using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment.Q01
{
    internal class Rectangle : IRectangle
    {
        public decimal Area 
        { 
            get;
            set;
        }

        public Rectangle(decimal Width, decimal Height)
        {
            Area = Width * Height;
        }
        public void DisplayShapeInfo()
        {
            Console.WriteLine($"Rec Area: {Area}");
        }
    }
}
