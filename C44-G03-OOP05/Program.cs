using System.Transactions;
using C44_G03_OOP05.Binding;
using C44_G03_OOP05.Interface;

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

            //Employee fullTimeEmp = new FullTimeEmp();
            //Employee partTimeEmp = new PartTimeEmp();

            ////ProcessEmployee(fullTimeEmp);
            //ProcessEmployee(partTimeEmp);

            #endregion

            #region Interface

            /* 
             *  Interface :- 
             *      - Code Contract Between 2 Developers First One Write The Interface Signatures
             *          Second One Implement All Interface Signature
             *      - Reference Type [Stack , Heap]
             *      - Qhat U Can Write Inside ?
             *          1. Signature For Property
             *          2. Signature For Method
             *          3. Default Implemented Method [C# 8.0]
             *              New Features
             *              4. Indexer
             *              5. Events
             *              6. Constants
             *              7. Operators
             *      - Types of Interface :-
             *          1. Top Level Interface
             *              Namespace => Access Modifier = Internal , Public
             *          2. Nasted Interface
             *              Create This Interface in Any Other Type
             * 
             */

            //IType refType;
            // Declare Reference Type From Type 'IType'
            // This REference Can Refer to an Object From Any Type That Implement IO 'IType'
            // CLR Will Allocate 4 Unitilized Bytes at Stack [Reference reType]

            //IType type = new IType();
            // Invalid => You Cannnot Take Object From Interface
            //refType = new TypeIO();

            //refType.MyProperty = 10;

            //refType.NyNethod();

            //refType.Print();

            //TypeIO type = new TypeIO();

            //type.MyProperty = 20;

            //type.NyNethod();

            //type.Print();
            
            #endregion
        }
    }
}
