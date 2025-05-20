using CondoBox.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CondoBox.Infrastructure.Repository.Interfaces;

public interface ISettingEmailRepository
{
    EmailSetting GetEmailSetting();
}
