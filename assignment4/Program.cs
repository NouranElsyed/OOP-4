using assignment4.part02;
using System.ComponentModel.Design;
using static System.Net.Mime.MediaTypeNames;

namespace assignment4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region  Q1
            //What is the primary purpose of an interface in C#?
            //b) To define a blueprint for a class
            #endregion
            #region  Q2
            //Which of the following is NOT a valid access modifier for interface members in C#?
            //a) private
            #endregion
            #region  Q3
            //Can an interface contain fields in C#?
            //b) No
            #endregion
            #region  Q4
            //In C#, can an interface inherit from another interface?
            //b) Yes, interfaces can inherit from multiple interfaces
            #endregion
            #region  Q5
            //Which keyword is used to implement an interface in a class in C#?
            //d) implements
            #endregion
            #region  Q6
            //Can an interface contain static methods in C#?
            //b) No
            #endregion
            #region  Q7
            //In C#, can an interface have explicit access modifiers for its members?
            //b) No, all members are implicitly public
            #endregion
            #region  Q8
            //What is the purpose of an explicit interface implementation in C#?
            //b) To provide a clear separation between interface and class members
            #endregion
            #region  Q9
            //In C#, can an interface have a constructor?
            //b) No, interfaces cannot have constructors
            #endregion
            #region  Q10
            //How can a C# class implement multiple interfaces?
            //c) By separating interface names with commas
            #endregion

            #region
            //part2
            //Question 01:
                //Define an interface named IShape with a property Area and a method DisplayShapeInfo.
                //Create two interfaces, ICircle and IRectangle, that inherit from IShape.
                //Implement these interfaces in classes Circle and Rectangle. 
                //Test your implementation by creating instances of both classes and displaying their shape information.

            Circle c1 = new Circle();

            for (int i = 0; ; i++)
            {
                Console.Write("Enter Radius : ");
                double radius ;
                bool success = double.TryParse(Console.ReadLine(), out radius);
                if (success)

                {
                    c1.Radius = radius; 
                    Console.WriteLine(" ");
                    c1.DisplayShapeInfo();
                break;
            }
                else
                { Console.WriteLine("it's not a number"); }
            }

            Console.WriteLine("\n=============\n");
            Rectangle t1 = new Rectangle();

            for (int i = 0; ; i++)
            {
                Console.Write("Enter Width : ");
                int Width;
                bool success01 = int.TryParse(Console.ReadLine(), out Width);
                if (success01)

                {
                    Console.Write("Enter Length : ");
                    int Length;
                    bool success02 = int.TryParse(Console.ReadLine(), out Length);
                    if (success02)
                    {

                        t1.Width= Width;
                        t1.Length= Length;
                        Console.WriteLine(" ");
                        t1.DisplayShapeInfo();
                        break;
                    }
                    else { Console.WriteLine("it's not a number"); }
                }
                else
                { Console.WriteLine("it's not a number"); }
            }


            #endregion

        }
}
}
