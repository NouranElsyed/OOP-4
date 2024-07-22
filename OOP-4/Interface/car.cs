using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_4.Interface
{
    internal class car : vechile, IMovable
    {
        public void Backword()
        {
            Console.WriteLine("car move Backword");
        }

        public void Forward()
        {
            Console.WriteLine("car move Forward");

        }

        public void Left()
        {
            Console.WriteLine("car move Left");

        }

        public void Right()
        {
            Console.WriteLine("car move Right");
        }
    }
}
