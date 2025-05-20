using CondoBox.Applications.Validator.Exceptions.EmptyField;
using CondoBox.Domain;
using CondoBox.Infrastructure.EmailService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CondoBox.Applications.Validator.SettingEmailValid.Interface;

public interface ISettingEmailValid
{
    public EmailSetting IsValid(
        string emailSender,
        string password,
        string smtpClient,
        string smtpPort,
        string emailCC,
        string emailSubject,
        string emailBody
        );
}
