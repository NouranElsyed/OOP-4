using OOP_4.Interface;

namespace OOP_4
{
 
    internal class Program
    {

        public static void Print10NumbersFromSeries(Iseries series)
        {
            if (series is not null)
            {
                for (int i = 0; i <= 10; i++)
                {
                    Console.Write($" {series.Current} ");
                    series.GetNext();
                }
                series.Reset();
            }
        }
        static void Main(string[] args) 
        {
            #region interface
            MyType myType = new MyType();
            myType.Id = 30;
            myType.MyFun(100);
            //myType.Print(); // invalid

            IMyType myType1 = new MyType();
            myType1.Id = 60;
            myType1.MyFun(600);
            myType1.Print(); // valid
            Console.WriteLine("\n");
            #endregion

            #region interface Ex01

            SeriesByTwo seriesByTwo = new SeriesByTwo();
            Print10NumbersFromSeries(seriesByTwo);
            Console.WriteLine("\n");
            #endregion

            #region implement interface Explicitly
            car car = new car();
            car.Backword(); // implicitly
            
            IMovable Movableplane = new airplane();
            IFlyable Flyableplane = new airplane();

            Movableplane.Backword();//explicitly
            Flyableplane.Backword();//explicitly

            #endregion




        }
    }
}
