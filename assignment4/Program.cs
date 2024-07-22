using assignment4.part02;
using assignment4.part02Q2;
using assignment4.part02Q3;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.Design;
using System.Data;
using System.Net;
using System.Threading.Channels;
using static System.Net.Mime.MediaTypeNames;
using static System.Runtime.InteropServices.JavaScript.JSType;

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

            #region P2 Q1
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

            #region P2 Q2
            //Question 02:
            //In this example, we start by defining the IAuthenticationService interface with two methods: AuthenticateUser and AuthorizeUser.The BasicAuthenticationService class implements this interface and provides the specific implementation for these methods.
            //In the BasicAuthenticationService class, the AuthenticateUser method compares the provided username and password with the stored credentials.It returns true if the user is authenticated and false otherwise.The AuthorizeUser method checks if the user with the given username has the specified role.It returns true if the user is authorized and false otherwise.
            //In the Main method, we create an instance of the BasicAuthenticationService class and assign it to the authService variable of type IAuthenticationService.We then call the AuthenticateUser and AuthorizeUser methods using this interface reference.
            //This implementation allows you to switch the authentication service implementation easily by creating a new class that implements the IAuthenticationService interface and providing the desired logic for authentication and authorization.
            BasicAuthenticationService user = new BasicAuthenticationService();
           if( user.AuthenticateUser("Nour" , 159))
           Console.WriteLine("welcome");
           else
                Console.WriteLine("something wrong");
            if (user.AuthenticateUser("Nouran", 123))
                Console.WriteLine("welcome");
            else
                Console.WriteLine("something wrong");
            if (user.AuthorizeUser("Nour", "user"))
                Console.WriteLine("welcome");
            else
                Console.WriteLine("something wrong");
            if (user.AuthorizeUser("Nouran", "Admin"))
           Console.WriteLine("welcome");
            else
                Console.WriteLine("something wrong");

            #endregion
            #region P2 Q3
            //Question 03:
            // we define the INotificationService interface with a method SendNotification that takes a recipient and a message as parameters.
            //We then create three classes: EmailNotificationService, SmsNotificationService, and PushNotificationService, which implement the INotificationService interface.
            //In each implementation, we provide the logic to send notifications through the respective communication channel:
            //The EmailNotificationService class simulates sending an email by outputting a message to the console.
            //The SmsNotificationService class simulates sending an SMS by outputting a message to the console.
            //The PushNotificationService class simulates sending a push notification by outputting a message to the console.
            //In the Main method, we create instances of each notification service class and call the SendNotification method with sample recipient and message values.
            //This implementation allows you to easily switch between different notification channels by creating new classes that implement the INotificationService interface and provide the specific logic for each channel.

            EmailNotificationService emailNotificationService = new EmailNotificationService();
            emailNotificationService.SendNotification("122.5212","email sended");
            SmsNotificationService smsNotificationService = new SmsNotificationService();
            smsNotificationService.SendNotification("122.5212", "sms sended");
            PushNotificationService pushNotificationService = new PushNotificationService();
            pushNotificationService.SendNotification("122.5212", "email sended");

            #endregion

        }
    }
}
