using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment4.part02
{
    internal class Circle : ICircle
    {
        public double Radius {  get; set; }
        public double Area { get { return 3.14 * Radius * Radius; } }

        public void DisplayShapeInfo()
        {
            Console.WriteLine($"Radius = {Radius} , Area = {Area}" ); 
        }
    }
}
