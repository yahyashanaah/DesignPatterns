
using DesignPatterns;
using DesignPatterns.FactoryMethod;

class Program
{
    static void Main(string[] args)
    {
        NotificationSender sender;

        sender = new EmailSender();
        sender.Notify("Welcome to our platform!");

        sender = new SmsSender();
        sender.Notify("Your OTP code is 123456.");

        sender = new PushSender();
        sender.Notify("You have a new friend request.");
    }
}
