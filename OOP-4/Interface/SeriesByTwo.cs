using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_4.Interface
{
    internal class SeriesByTwo : Iseries
    {
        public int Current { get; set; }

        public void GetNext()
        {
            Current += 2;
        }


    }
}
