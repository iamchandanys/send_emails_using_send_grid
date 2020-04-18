using SendGrid;
using SendGrid.Helpers.Mail;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Send.Emails.Using.SendGrid
{
    public class SendEmails
    {
        public async Task SendDynamicMail()
        {
            try
            {
                var apiKey = "ADD_SEND_GRID_API_KEY_HERE";
                var client = new SendGridClient(apiKey);

                TemplateData templateData = new TemplateData()
                {
                    Subject = "Verification",
                    Title = "OTP Verification",
                    Name = "Chandan Y S",
                    Otp = "8634"
                };

                var msg = new SendGridMessage();
                msg.SetFrom(new EmailAddress("abc@gmail.com", "ABC"));
                msg.AddTo(new EmailAddress("xyz@gmail.com", "XYZ"));
                msg.SetTemplateId("ADD_TEMPLATE_ID_HERE");
                msg.SetTemplateData(templateData);

                var response = await client.SendEmailAsync(msg);
                Console.WriteLine(response.StatusCode);
                Console.ReadLine();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.ReadLine();
            }
        }
    }
}
