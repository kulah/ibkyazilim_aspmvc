using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Web;

namespace ibkyazilim_LandingPage.Models
{
    public static class Gmail
    {
        public static void SendMail(string body)
        {

            var fromAddress = new MailAddress("info@ibkyazilim.com", "IBKYAZILIM İletişim Formu Bildirimleri");
            var toAddress = new MailAddress("info@ibkyazilim.com");
            const string subject = "IBKYAZILIM İletişim Formu Bildirimleri";
            using (var smtp = new SmtpClient
            {
                Host = "mail.ibkyazilim.com",
                Port = 587,
                EnableSsl = false,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,
                Credentials = new NetworkCredential("info@ibkyazilim.com", "ibkyaz1453")
            })
            {
                using (var message = new MailMessage("info@ibkyazilim.com", "info@ibkyazilim.com") { Subject = subject, Body = body })
                {
                    smtp.Send(message);
                }
            }
        }
    }                       
}