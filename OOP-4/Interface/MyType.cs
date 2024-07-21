using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_4.Interface
{
    internal class MyType : IMyType
    {
        public int Id { get; set; }

        public void MyFun(int x)
        {
            Console.WriteLine($"Hello Route : X = {x} , Id = {Id}");
        }
    }
}
