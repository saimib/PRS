using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Web;
using System.Text;

namespace PatientRegistrationSystem.Models
{
    public class SMTP
    {

        public static void sendMail(string email)
        {
           
            string senderID = "emisdeveloper0@gmail.com";
          
            const string senderPassword = "ascribe1";
            try
            {
                SmtpClient smtp = new SmtpClient
                {
                    Host = "smtp.gmail.com",
                    Port = 587,
                    EnableSsl = true,
                    DeliveryMethod = SmtpDeliveryMethod.Network,
                    UseDefaultCredentials = false,
                    Credentials = new System.Net.NetworkCredential(senderID, senderPassword),
                    Timeout = 30000,
                };
                MailMessage message = new MailMessage(senderID, email, "AppointMent Confirmation","Your Appointment is confirmed Please Log in to the PRS");
                smtp.Send(message);
            }
            catch (Exception ex)
            {
               
            }

            


        }
    }

}