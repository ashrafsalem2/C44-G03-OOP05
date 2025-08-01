using System.Transactions;
using C44_G03_OOP05.Binding;

namespace C44_G03_OOP05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Binding
            /*
             * Reference From Parent Refer To Object From Child
             */
            TypeA type = new TypeB(1, 2);

            type.A = 10;
            //type.B - 20;

            type.Func01(); // Parent Class

            type.Func02(); // Go To Last Override of Function
            #endregion
        }
    }
}
