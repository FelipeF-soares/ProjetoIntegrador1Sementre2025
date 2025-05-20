using CondoBox.Applications.Persist.Interface;
using CondoBox.Domain;
using CondoBox.Infrastructure.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CondoBox.Applications.Persist;

public class MailPersist : IMailPersist
{
    private readonly IGenericRepository generic;
    private readonly IMailRepository mailRepository;

    public MailPersist(IGenericRepository generic, IMailRepository mailRepository)
    {
        this.generic = generic;
        this.mailRepository = mailRepository;
    }
    public async Task<bool> AddMailAsync(Mail model)
    {
        try
        {
            generic.Add(model);
            return await generic.SaveChangesAsync();
        }
        catch(Exception)
        {
            throw new Exception("Erro ao Registrar encomenda.");
        }
    }

    public Task<IEnumerable<Mail>> GetAllMailAsync()
    {
        throw new NotImplementedException();
    }

    public Task<bool> GetMailByIdAsync(int id)
    {
        throw new NotImplementedException();
    }
}
