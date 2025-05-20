using CondoBox.Applications.Persist.Interface;
using CondoBox.Domain;
using CondoBox.Infrastructure.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CondoBox.Applications.Persist;

public class SettingEmailPersist : ISettingEmailPersist
{
    private readonly IGenericRepository generic;
    private readonly ISettingEmailRepository settingEmail;

    public SettingEmailPersist(IGenericRepository generic, ISettingEmailRepository settingEmail)
    {
        this.generic = generic;
        this.settingEmail = settingEmail;
    }

    public EmailSetting GetEmail()
    {
        try
        {
            return settingEmail.GetEmailSetting();
        }
        catch(Exception ex)
        {
            throw new Exception("Erro ao carregar as Informações de configuração do email");
        }
    }

    public Task<bool> SalveSettingEmail(EmailSetting model)
    {
        try
        {
            generic.Add(model);
            return generic.SaveChangesAsync();
        }
        catch(Exception)
        {
            throw new Exception("Erro ao salvar Informações");
        }
    }
}
