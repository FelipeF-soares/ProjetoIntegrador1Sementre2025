using CondoBox.Domain;
using CondoBox.Infrastructure.Data;
using CondoBox.Infrastructure.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CondoBox.Infrastructure.Repository;

public class SettingEmailRepository : ISettingEmailRepository
{
    private readonly AppDbContext context;

    public SettingEmailRepository(AppDbContext context)
    {
        this.context = context;
    }
    public EmailSetting GetEmailSetting()
    {
        return context.EmailSend.FirstOrDefault(setting => setting.Id == 0);
    }
}
