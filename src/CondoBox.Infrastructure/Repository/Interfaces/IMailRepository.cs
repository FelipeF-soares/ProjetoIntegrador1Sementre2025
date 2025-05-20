using CondoBox.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CondoBox.Infrastructure.Repository.Interfaces;

public interface IMailRepository
{
    Task<IEnumerable<Mail?>> GetAllMailAsync();
    Task<IEnumerable<Mail?>> GetAllMailByUnit(Unit unit);
    Task<Mail?> GetMailById(int id);
    
}
