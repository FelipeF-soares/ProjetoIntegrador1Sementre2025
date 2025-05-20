using CondoBox.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CondoBox.Applications.Persist.Interface;

public interface IResidentPersist
{
    Task<bool> AddResisdentAsync(Resident model);
    Task<bool> UpdateResisdentAsync(int id, Resident model);
    Task<bool> DeleteResisdentAsync(int id);
    Task<IEnumerable<Resident>> GetAllResidentsAsync();
    Task<Resident> GetResidentByCpfAsync(string cpf);
    Task<Resident> GetResidentByIdAsysnc(int id);
}
