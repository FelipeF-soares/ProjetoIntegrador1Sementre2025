using CondoBox.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CondoBox.Applications.Persist.Interface;

public interface IMailPersist
{
    Task<bool> AddMailAsync(Mail model);
    Task<bool> GetMailByIdAsync(int id);
    Task<IEnumerable<Mail>> GetAllMailAsync();
}
