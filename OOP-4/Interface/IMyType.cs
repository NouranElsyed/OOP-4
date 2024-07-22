using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_4.Interface
{
    internal interface IMyType
    {
        public int Id { get; set; }
        public void MyFun(int x);
        public void Print() 
        {
            Console.WriteLine("Hello Default Implemented Method From Interface");
        }
    }
}
