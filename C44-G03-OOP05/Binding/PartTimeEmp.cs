using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C44_G03_OOP05.Binding
{
    internal class PartTimeEmp : Employee
    {
        public decimal HourRate { get; set; }
        public int CountOfHours { get; set; }

        public new void Func01()
        {
            Console.WriteLine("Hello From Part Time Employee");
        }

        public new void Func02()
        {
            Console.WriteLine($"Emp Data :-  Id: {Id} | Name: {Name} | Age: {Age} | Hour Rate: {HourRate} | Count Of Hours: {CountOfHours} ");
        }
    }
}
