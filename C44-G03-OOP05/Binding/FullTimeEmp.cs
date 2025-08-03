using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C44_G03_OOP05.Binding
{
    internal class FullTimeEmp : Employee
    {
        public decimal Salary { get; set; }

        public override void Func01()
        {
            Console.WriteLine("Hello From Full Time Employee");
        }
        public override void Func02()
        {
            Console.WriteLine($"Emp Data :-  Id: {Id} | Name: {Name} | Age: {Age} | Salary: {Salary} ");
        }
    }
}
