using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment4.part02Q3
{
    internal class SmsNotificationService : INotificationService
    {
        public void SendNotification(string recipient, string message)
        {
            Console.WriteLine($"sms notification sent to {recipient}");
            Console.WriteLine($"message {message}");
        }
    }
}
