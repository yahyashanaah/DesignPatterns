using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    public abstract class NotificationSender
    {
        public abstract INotification CreateNotification();

        public void Notify(string message)
        {
            var notification = CreateNotification();
            notification.Send(message);
        }
    }

}
