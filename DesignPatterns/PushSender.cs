using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    public class PushSender : NotificationSender
    {
        public override INotification CreateNotification()
        {
            return new PushNotification();
        }
    }
}
