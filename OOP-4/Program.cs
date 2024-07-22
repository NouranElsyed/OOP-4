using OOP_4.Interface;
using System;
using System.Text;

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
            car.Backward(); // implicitly

            IMovable Movableplane = new airplane();
            IFlyable Flyableplane = new airplane();

            Movableplane.Backward();//explicitly
            Flyableplane.Backward();//explicitly
            Console.WriteLine("\n");

            #endregion

            #region Shallow copy and Deep copy

            #region value type 
            //int[] arr01 = { 1, 2, 3 };
            //int[] arr02 = new int[3];

            //Console.WriteLine($"HC of arr01 : {arr01.GetHashCode()}"); //54267293
            //Console.WriteLine($"HC of arr02 : {arr02.GetHashCode()}"); //18643596

            //Console.WriteLine("\n");

            #region shallow copy

            //arr02 = arr01; //shallow copy
            //Console.WriteLine("After shallow copy");

            //Console.WriteLine($"HC of arr01 : {arr01.GetHashCode()}"); //54267293
            //Console.WriteLine($"HC of arr02 : {arr02.GetHashCode()}"); //54267293

            //arr01[2] = 100;

            //Console.WriteLine($"arr01[2] = {arr01[2]}");
            //Console.WriteLine($"arr02[2] = {arr02[2]}");
            //Console.WriteLine("\n");


            //Console.WriteLine("\n");
            #endregion
            #region deep copy
            //arr02 = (int[])arr01.Clone(); //deep copy
            //Console.WriteLine("After deep copy");

            //Console.WriteLine($"HC of arr01 : {arr01.GetHashCode()}"); //54267293
            //Console.WriteLine($"HC of arr02 : {arr02.GetHashCode()}"); //33574638


            //arr01[1] = 10;

            //Console.WriteLine($"arr01[1] = {arr01[1]}");
            //Console.WriteLine($"arr02[1] = {arr02[1]}");

            //Console.WriteLine("\n");
            #endregion

            #endregion

            #region reference type 
            #region array of string
            //string[] Name01 = { "Nouran" };
            //string[] Name02 = new string[1];

            //Console.WriteLine($"HC of Name01 : {Name01.GetHashCode()}"); //54267293
            //Console.WriteLine($"HC of Name02 : {Name02.GetHashCode()}"); //18643596

            //Console.WriteLine("\n");

            #region shallow copy

            //Name02 = Name01; //shallow copy
            //Console.WriteLine("After shallow copy");

            //Console.WriteLine($"HC of Name01  : {Name01.GetHashCode()}"); //54267293
            //Console.WriteLine($"HC of Name02  : {Name02.GetHashCode()}"); //54267293

            //Console.WriteLine($"Name01 [0] = {Name01[0]}");
            //Console.WriteLine($"Name02 [0]  = {Name02[0]}");

            //Name01[0] = "Amr";
            //Console.WriteLine("change  Name01[0]  ");

            //Console.WriteLine($"Name01 [0] = {Name01[0]}");
            //Console.WriteLine($"Name02 [0]  = {Name02[0]}");
            //Console.WriteLine("\n");



            #endregion
            #region deep copy


            //Name02 = (string[])Name01.Clone(); //shallow copy

            //Console.WriteLine("After deep copy");

            //Console.WriteLine($"HC of Name01  : {Name01.GetHashCode()}"); //54267293
            //Console.WriteLine($"HC of Name02  : {Name02.GetHashCode()}"); //54267293

            //Console.WriteLine($"Name01 [0] = {Name01[0]}");
            //Console.WriteLine($"Name02 [0]  = {Name02[0]}");

            //Name01[0] = "Amr";
            //Console.WriteLine("change  Name01[0]  ");

            //Console.WriteLine($"Name01 [0] = {Name01[0]}");
            //Console.WriteLine($"Name02 [0]  = {Name02[0]}");
            //Console.WriteLine("\n");
            #endregion

            #endregion

            #region array of stringbuilder
            //StringBuilder[] Names01 = new StringBuilder[1];
            //Names01[0] = new StringBuilder("Omar");

            //StringBuilder[] Names02 = new StringBuilder[1];


            //Console.WriteLine($"HC of Name01 : {Names01.GetHashCode()}"); // 54267293
            //Console.WriteLine($"HC of Name02 : {Names02.GetHashCode()}"); //18643596

            #region shallow copy
            //Names02 = Names01;
            //Console.WriteLine("After shallow copy");


            //Console.WriteLine($"HC of Name01 : {Names01.GetHashCode()}"); // 54267293
            //Console.WriteLine($"HC of Name02 : {Names02.GetHashCode()}"); // 54267293
            //Console.WriteLine($"Names01 [0] = {Names01[0]}");
            //Console.WriteLine($"Names02 [0]  = {Names02[0]}");

            //Names02[0].Append(" Amr");
            //Console.WriteLine("change  Names01[0]  ");

            //Console.WriteLine($"Names01 [0] = {Names01[0]}");
            //Console.WriteLine($"Names02 [0]  = {Names02[0]}");
            //Console.WriteLine("\n");
            #endregion



            #region deep copy
            //Names02 = (StringBuilder[])Names01.Clone();
            //Console.WriteLine("After deep copy");

            //Console.WriteLine($"HC of Name01 : {Names01.GetHashCode()}"); // 54267293
            //Console.WriteLine($"HC of Name02 : {Names02.GetHashCode()}"); // 33574638
            //Console.WriteLine($"Names01 [0] = {Names01[0]}");
            //Console.WriteLine($"Names02 [0]  = {Names02[0]}");

            //Names02[0].Append(" Amr");
            //Console.WriteLine("change  Names01[0]  ");

            //Console.WriteLine($"Names01 [0] = {Names01[0]}");
            //Console.WriteLine($"Names02 [0]  = {Names02[0]}");
            //Console.WriteLine("\n");
            #endregion


            #endregion


            #endregion

            #endregion

            #region ICloneable
            Employee employee01 = new Employee() { Id = 20, Name = "Hala", Salary = 6000 };
            Employee employee02 = new Employee() { Id = 25, Name = "Mai", Salary = 10000 };

            Console.WriteLine($"HC of employee01 : {employee01.GetHashCode()}");
            Console.WriteLine($"employee01 : {employee01}");
            //HC of employee01: 54267293
            //employee01: Id: 20 , Name: Hala , Salary: 6000

            Console.WriteLine($"HC of employee02 : {employee02.GetHashCode()}");
            Console.WriteLine($"employee02 : {employee02}");
            //HC of employee02: 18643596
            //employee02: Id: 25 , Name: Mai , Salary: 10000

            employee02 = (Employee)employee01.Clone();
            Console.WriteLine("After deep copy");

            Console.WriteLine($"HC of employee01 : {employee01.GetHashCode()}");
            Console.WriteLine($"employee01 : {employee01}");
            //HC of employee01: 54267293
            //employee01: Id: 20 , Name: Hala , Salary: 6000

            Console.WriteLine($"HC of employee02 : {employee02.GetHashCode()}");
            Console.WriteLine($"employee02 : {employee02}");
            //HC of employee02: 33574638
            //employee02: Id: 20 , Name: Hala , Salary: 6000

            employee02.Id = 30;
            employee02.Name = "Samar";
            employee02.Salary = 7500;

            Console.WriteLine("After change employee02 values");

            Console.WriteLine($"HC of employee01 : {employee01.GetHashCode()}");
            Console.WriteLine($"employee01 : {employee01}");
            //HC of employee01: 54267293
            //employee01: Id: 20 , Name: Hala , Salary: 6000

            Console.WriteLine($"HC of employee02 : {employee02.GetHashCode()}");
            Console.WriteLine($"employee02 : {employee02}");
            //HC of employee02: 33574638
            //employee02: Id: 30 , Name: Samar , Salary: 7500


            employee02 = new Employee(employee01);

            Console.WriteLine("After deep copy with copy constructor");

            Console.WriteLine($"HC of employee01 : {employee01.GetHashCode()}");
            Console.WriteLine($"employee01 : {employee01}");
            //HC of employee01: 54267293
            //employee01: Id: 20 , Name: Hala , Salary: 6000

            Console.WriteLine($"HC of employee02 : {employee02.GetHashCode()}");
            Console.WriteLine($"employee02 : {employee02}");
            //HC of employee02: 33574638
            //employee02: Id: 30 , Name: Samar , Salary: 7500


            Console.WriteLine("\n===================================\n");

            #endregion

            #region icomparable
            Employee[] employees = new Employee[4]
            {
            new Employee(){ Id =10 , Name= "Aliaa" , Salary = 10000},
            new Employee(){ Id =20 , Name= "Hala" , Salary = 20000},
            new Employee(){ Id =30 , Name= "Mai" , Salary = 25000},
            new Employee(){ Id =40 , Name= "Samar" , Salary = 15000}
            };
            Array.Sort(employees);
            foreach (Employee emp in employees)
            {
                Console.WriteLine(emp);
            }
            Console.WriteLine("\n===================================\n");
            #endregion

            #region icomparer
            Array.Sort( employees , new EmployeeIdComparer());
            foreach (Employee emp in employees)
            {
                Console.WriteLine(emp);
            }
            #endregion

        }
    }
}
