using OOP_4.Interface;

namespace OOP_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyType myType = new MyType();
            myType.Id = 30;
            myType.MyFun(100);
            //myType.Print(); // invalid

            IMyType myType1 = new MyType();
            myType1.Id = 60;
            myType1.MyFun(600);
            myType1.Print(); // valid

        }
    }
}
