using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C44_G03_OOP05.Binding
{
    internal class Employee
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public int Age { get; set; }

        public virtual void Func01() 
        {
            Console.WriteLine("Employee Class");
        }

        public virtual void Func02() 
        {
            Console.WriteLine($"Emp Data :-  Id: {Id} | Name: {Name} | Age: {Age} ");
        }
    }
}
