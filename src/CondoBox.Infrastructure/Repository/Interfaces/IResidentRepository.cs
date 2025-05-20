using CondoBox.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CondoBox.Infrastructure.Repository.Interfaces;

public interface IResidentRepository
{
    Task<IEnumerable<Resident?>> GetAllResidentsAsync();
    Task<IEnumerable<Resident?>> GetAllResidentsByBuildingAndApt(string building, string apt);
    Task <Resident?> GetResidentsByIdAsync(int id);
    Task <Resident?> GetResidentsByCPFAsync(string cpf);
}
