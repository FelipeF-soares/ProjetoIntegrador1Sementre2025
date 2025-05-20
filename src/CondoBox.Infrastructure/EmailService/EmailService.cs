using CondoBox.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace CondoBox.Infrastructure.EmailService;

public class EmailService
{
    
    public bool SendEmail(List<Resident> residents, EmailSetting setting)
    {
        try
        {
            MailMessage mail = new MailMessage();
            mail.From = new MailAddress(setting.EmailSender);
            foreach(var resident in residents)
            {
                mail.To.Add(resident.Email);
            }
            if(!string.IsNullOrEmpty(setting.EmailCC))
            {
                mail.CC.Add(setting.EmailCC);
            }
            mail.Subject = setting.EmailSubject;
            mail.Body = setting.EmailBody;
            
            SmtpClient smtp = new SmtpClient(setting.SmtpClient, int.Parse(setting.SmtpPort));
            string password = CryptoService.Decrypt(setting.CryptoPassword);
            smtp.Credentials = new NetworkCredential(setting.EmailSender, password);
            smtp.EnableSsl = true;

            smtp.Send(mail);
            return true;
        }
        catch (Exception)
        {
            throw new Exception("Erro ao enviar e-mail");
        }
    }
}
