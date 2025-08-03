using System.Net.Http.Headers;
using System.Transactions;
using C44_G03_OOP05.Binding;
using C44_G03_OOP05.Built_In_IO;
using C44_G03_OOP05.Example01IO;
using C44_G03_OOP05.ExampleTwoIO;
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

        #region Ex 01 Interface


        static void SeriesToPrintFiveNum(ISeries series) 
        {
            if (series is not null)
            {
                for (int i = 0; i <= 5; i++)
                {
                    Console.WriteLine(series.Current);
                    series.GetNextValue();
                }

                series.ResetSeries();
            }
            else 
            {
                return;
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

            #region Ex 01 Interface
            /*
             *  Series
             *  Property To Carry CurrentValue
             *  Method To GetNextValue
             *  Method To Reset
             */

            //SeriesOne S1 = new SeriesOne();
            //SeriesToPrintFiveNum(S1);

            //SeriesTwo S2 = new SeriesTwo();
            //SeriesToPrintFiveNum(S2);
            #endregion

            #region Ex 02 Interface

            //Car car = new Car();
            //car.Speed = 300;
            //car.Forward();
            //car.Backward();
            //car.Left();
            //car.Right();

            //Airplane airplane = new Airplane();

            //airplane.Speed = 600;
            //airplane.Forward();
            //airplane.Backward();
            //airplane.Left();
            //airplane.Right();

            //IMoveOnAir moveAir = new Airplane();

            //IMoveOnGround ground = new Car();
            //IMoveOnGround ground1 = new Airplane();

            //ground1.Backward();

            #endregion

            #region Built-in Interface

            /*
             * IEnumerable<T> : GetEnumrator() => Foreach
             * 
             * ICollection<T> : [Add] Method For Adding, Remove => Remove()
             * 
             * IList<T> : Convert Any Type to Index
             * 
             * IComparable<T> : CompareTo()
             * 
             * IDisposable() : Dispose() => Connection of Database
             * 
             * ICloneble() : Clone()
             * 
             * IComparer<T> : Compare()
             * 
             * IReadOnly Collection<T> : Count(), GetEnumerator()
             * 
             */

            #region ICloneable

            //User user01 = new User() { Id = 1, Name = "Ahmed", Salary=5000 };
            //User user02 = new User() { Id = 2, Name = "Mai", Salary = 7000 };

            //Console.WriteLine($"User 01 : {user01.GetHashCode()}"); // 43942917
            //Console.WriteLine($"User 02 : {user02.GetHashCode()}"); // 59941933
            //Console.WriteLine(user01);
            //Console.WriteLine(user02);
            //Console.WriteLine("=================================");
            //Console.WriteLine("=================================");
            //user02 = (User) user01.Clone();

            //Console.WriteLine($"User 01 : {user01.GetHashCode()}"); // 43942917
            //Console.WriteLine($"User 02 : {user02.GetHashCode()}"); // 2606490
            //Console.WriteLine("=========================");
            //Console.WriteLine(user01);
            //Console.WriteLine(user02);

            #endregion

            #region IComparable()  

            //int[] numbers = { 6, 3, 1, 2, 5, 4 };


            //User[] users = 
            //{
            //    new User() { Id = 10, Name = "Hossam", Salary = 10000},          
            //    new User() { Id = 20, Name = "Noor", Salary = 7000},          
            //    new User() { Id = 30, Name = "Ali", Salary = 15000},          
            //    new User() { Id = 40, Name = "Mohamed", Salary = 9000}          
            //};


            //Array.Sort(users);

            //for (int i = 0;i < users.Length;i++)
            //    Console.WriteLine(users[i]);

            #endregion

            #region IComparer

            // Sort Based on Name

            //Array.Sort(users, new UserNameComparer());
            //for (int i = 0; i < users.Length; i++)
            //    Console.WriteLine(users[i]);
                
            
            #endregion

            #endregion



        }
    }
}
