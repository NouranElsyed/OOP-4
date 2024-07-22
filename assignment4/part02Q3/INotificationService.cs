using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment4.part02Q3
{
    internal interface INotificationService
    {
        public void SendNotification(string recipient, string message);
    }
}
