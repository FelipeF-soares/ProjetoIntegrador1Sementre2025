using CondoBox.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CondoBox.Applications.Persist.Interface;

public interface ISettingEmailPersist
{
    Task<bool> SalveSettingEmail(EmailSetting model);

    EmailSetting GetEmail();
   
}
