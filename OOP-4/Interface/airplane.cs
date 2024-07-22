using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_4.Interface
{
    internal class airplane : vehicle, IMovable, IFlyable
    {



        void IMovable.Backward()
        {
            Console.WriteLine("airplane move Movable Backward");
        }

        void IFlyable.Backward()
        {
            Console.WriteLine("airplane move Flyable Backward");

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
