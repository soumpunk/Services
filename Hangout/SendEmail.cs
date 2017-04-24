using SendGrid;
using System.Configuration;
using SendGrid.Helpers.Mail;
using System.Threading.Tasks;
namespace Hangout
{
    public class SendEmail
    {
        public Task SendOneEmail(string activationCode, string email)
        {
            var myMessage = new SendGridMessage()
            {
                From = new EmailAddress("savyitsol@gmail.com", "Wineoutlet"),
                Subject = "Test mail for Winehangoutz",
                PlainTextContent = "Hello, Email!",
                HtmlContent = "<strong>Hello, Email!</strong><br /><br />Please click the following link to activate your account<br /><a href =" + "http://localhost:65442/api/item/UpdateVerifiedEmail/" + activationCode + ">Click here to activate your account.</a><br /><br />Thanks"
            };
            //ActivationCode=" + activationCode) + 
            myMessage.AddTo(new EmailAddress(email, "Test User"));

            var apiKey = ConfigurationManager.AppSettings["SENDGRID_APIKEY"];
            var client = new SendGridClient(apiKey);
            var response = client.SendEmailAsync(myMessage);
            return response;
        }
    }
}