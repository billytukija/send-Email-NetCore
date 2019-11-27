using MailKit.Net.Smtp;
using MimeKit;
using System;

namespace send_Email_NetCore2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var message = new MimeMessage();
            message.From.Add(new MailboxAddress("Billy", "billytukija@gmail.com"));
            message.To.Add(new MailboxAddress("Grazzy", "graziellytukija@beapps.com.br"));
            message.Subject = "Aprovação";
            message.Body = new TextPart("plain")
            {
                Text = "Hey Grazzy .. "
            };

            using (var client = new SmtpClient())
            {
                client.Connect("smtp.gmail.com", 587, false);
                client.Authenticate("billytukija@gmail.com", "#########");
                client.Send(message);
                client.Disconnect(true);
            }
        }
    }
}
