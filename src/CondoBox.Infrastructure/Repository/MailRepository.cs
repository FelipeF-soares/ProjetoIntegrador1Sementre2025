using CondoBox.Domain;
using CondoBox.Infrastructure.Data;
using CondoBox.Infrastructure.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CondoBox.Infrastructure.Repository;

public class MailRepository : IMailRepository
{
    private readonly AppDbContext context;

    public MailRepository(AppDbContext context)
    {
        this.context = context;
    }
    public async Task<IEnumerable<Mail?>> GetAllMailAsync()
    {
        return await context.Mails.ToListAsync();
    }
    public Task<IEnumerable<Mail?>> GetAllMailByUnit(Unit unit)
    {
        throw new NotImplementedException();
    }
    public Task<Mail?> GetMailById(int id)
    {
        return context.Mails.FirstOrDefaultAsync(mail => mail.Id == id);
    }
}
