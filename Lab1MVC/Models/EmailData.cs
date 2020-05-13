using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Web;

namespace Lab1MVC.Models
{
    public class EmailData
    {

        public int SendEmail(string to)
        {
            int resultToRetur=0;
            
            string from = "ucrrecintoparaiso@gmail.com";
            string password = "UCR1997.";

            MailMessage mailMessage = new MailMessage(from, to, "se ha registrado correctamente", "<p>esto se debe ver negro</p>");
            mailMessage.IsBodyHtml = true;

            SmtpClient smtpClient = new SmtpClient("smtp.gmail.com");
            smtpClient.EnableSsl = true;
            smtpClient.UseDefaultCredentials = false;
            smtpClient.Port = 587;
            smtpClient.Credentials = new System.Net.NetworkCredential(from, password);
            smtpClient.Send(mailMessage);
            smtpClient.Dispose();
            return resultToRetur;
        }


    }
}
