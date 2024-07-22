using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment4.part02
{
    internal class Rectangle:IRectangle
    {
        public double Width { get; set; }
        public double Length { get; set; }

        public double Area { get { return  Width * Length; } }

        public void DisplayShapeInfo()
        {
            Console.WriteLine($"Length = {Length} ,Width = {Width} , Area = {Area}");
        }
    }
}
