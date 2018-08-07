using System.Net;
using System.Net.Mail;

namespace PC_Admin_Panel.Classes
{
    class Send_Mail
    {
        /// <summary>
        /// Method send e-mail
        /// </summary>
        /// <param name="sender"> Who send e-mail </param>
        /// <param name="recipient"> Recipiend of e-mail </param>
        /// <param name="message"> E-mail message </param>
        /// <param name="subject"> E-mail subject </param>
        public static void Mail(string sender, string recipient, string message, string subject)
        {
            using (MailMessage Message = new MailMessage(sender, recipient))
            {
                Message.Subject = subject;
                Message.Body = message;
                Message.IsBodyHtml = true;
                using (SmtpClient smtp = new SmtpClient())
                {
                    smtp.Host = "smtp.gmail.com";
                    smtp.EnableSsl = true;

                    NetworkCredential NetworkCard = new NetworkCredential("piotr.murdzia.csharp.testy@gmail.com", "takiehaslo123456789");

                    smtp.UseDefaultCredentials = true;
                    smtp.Credentials = NetworkCard;
                    smtp.Port = 587;
                    smtp.Send(Message);
                }
            }
        }
    }
}
