using System;
using System.Threading.Tasks;

namespace Send.Emails.Using.SendGrid
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            SendEmails sendEmails = new SendEmails();

            sendEmails.SendDynamicMail().Wait();
        }
    }
}
