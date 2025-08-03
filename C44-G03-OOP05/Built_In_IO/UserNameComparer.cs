using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C44_G03_OOP05.Built_In_IO
{
    internal class UserNameComparer : IComparer<User>
    {
        public int Compare(User? x, User? y)
        {
            // X > Y => 1
            // X < Y => -1
            // X == Y => 0

            return string.Compare(x?.Name, y?.Name);
        }
    }
}
