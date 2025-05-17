using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.FactoryMethod
{
    public class SmsSender : NotificationSender
    {
        public override INotification CreateNotification()
        {
            return new SmsNotification();
        }
    }
}
