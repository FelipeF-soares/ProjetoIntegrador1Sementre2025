using CondoBox.Applications.Validator.Exceptions.EmptyField;
using CondoBox.Applications.Validator.SettingEmailValid.Interface;
using CondoBox.Domain;
using CondoBox.Infrastructure.EmailService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CondoBox.Applications.Validator.SettingEmailValid;

public class SettingEmailValid : ISettingEmailValid
{
    public EmailSetting IsValid
        (
        string emailSender, 
        string password, 
        string smtpClient, 
        string smtpPort, 
        string emailCC, 
        string emailSubject, 
        string emailBody
        )
    {
        FieldValid.IsEmptyOrWhiteSpace(emailSender);
        FieldValid.IsEmptyOrWhiteSpace(password);
        FieldValid.IsEmptyOrWhiteSpace(smtpClient);
        FieldValid.IsEmptyOrWhiteSpace(smtpPort);
        FieldValid.IsEmptyOrWhiteSpace(emailSubject);
        FieldValid.IsEmptyOrWhiteSpace(emailBody);

        var emailSetting = new EmailSetting();
        emailSetting.EmailSender = emailSender.ToLower().Trim();
        emailSetting.CryptoPassword = CryptoService.Encrypt(password);
        emailSetting.SmtpClient = smtpClient.ToLower().Trim();
        emailSetting.SmtpPort = smtpPort.Trim();
        emailSetting.EmailCC = emailCC;
        emailSetting.EmailSubject = emailSubject;
        emailSetting.EmailBody = emailBody;

        return emailSetting;
    }
}
