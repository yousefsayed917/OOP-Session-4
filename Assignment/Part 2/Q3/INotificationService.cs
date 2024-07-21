using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Part_2.Q3
{
    internal interface INotificationService
    {
        public void SendNotification(string recipient, string message);

    }
}
