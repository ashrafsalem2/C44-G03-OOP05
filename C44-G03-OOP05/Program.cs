using System.Transactions;
using C44_G03_OOP05.Binding;

namespace C44_G03_OOP05
{
    internal class Program
    {
        #region Binding Usage
        //public static void ProcessEmployee(FullTimeEmp fullTimeEmp)
        //{
        //    if (fullTimeEmp is not null)
        //    {
        //        fullTimeEmp.Func01();
        //        fullTimeEmp.Func02();
        //    }
        //}
        //public static void ProcessEmployee(PartTimeEmp partTimeEmp)
        //{
        //    if (partTimeEmp is not null)
        //    {
        //        partTimeEmp.Func01();
        //        partTimeEmp.Func02();
        //    }
        //}
        public static void ProcessEmployee(Employee emp) 
        {
            if (emp is not null) 
            {
                emp.Func01();
                emp.Func02();
            }
        }
        #endregion
        static void Main(string[] args)
        {
            #region Binding
            /*
             * Reference From Parent Refer To Object From Child
             */
            //TypeA type = new TypeB(1, 2);

            //type.A = 10;
            ////type.B - 20;

            //type.Func01(); // Parent Class

            //type.Func02(); // Go To Last Override of Function

            #endregion

            #region Binding Usage

            Employee fullTimeEmp = new FullTimeEmp();
            Employee partTimeEmp = new PartTimeEmp();

            //ProcessEmployee(fullTimeEmp);
            ProcessEmployee(partTimeEmp);

            #endregion
        }
    }
}
