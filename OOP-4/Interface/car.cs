using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_4.Interface
{
    internal class car : vehicle, IMovable
    {
        public void Backward()
        {
            Console.WriteLine("car move Backward");
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
