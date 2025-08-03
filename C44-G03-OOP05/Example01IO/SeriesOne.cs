using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C44_G03_OOP05.Example01IO
{
    internal class SeriesOne : ISeries
    {
        public int Current { 
            get;
            set;
        }

        public void GetNextValue()
        {
            Current += 2;
        }
    }
}
