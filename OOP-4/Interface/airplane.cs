using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_4.Interface
{
    internal class airplane : vechile, IMovable, IFlyable
    {



        void IMovable.Backword()
        {
            Console.WriteLine("airplane move Movable Backword");
        }

        void IFlyable.Backword()
        {
            Console.WriteLine("airplane move Flyable Backword");

        }

        void IMovable.Forward()
        {
            Console.WriteLine("airplane move Movable Forward");
        }

        void IFlyable.Forward()
        {
            Console.WriteLine("airplane move Flyable Forward");

        }

        void IMovable.Left()
        {
            Console.WriteLine("airplane move Movable Left");
        }

        void IFlyable.Left()
        {
            Console.WriteLine("airplane move Flyable Left");

        }

        void IMovable.Right()
        {
            Console.WriteLine("airplane move Movable Right");
        }

        void IFlyable.Right()
        {
            Console.WriteLine("airplane move Flyable Right");

        }
    }
}
