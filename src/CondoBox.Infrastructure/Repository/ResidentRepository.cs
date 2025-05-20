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

public class ResidentRepository : IResidentRepository
{
    private readonly AppDbContext context;

    public ResidentRepository(AppDbContext context)
    {
        this.context = context;
    }
    public Task<IEnumerable<Resident?>> GetAllResidentsAsync()
    {
        throw new NotImplementedException();
    }
    public Task<IEnumerable<Resident?>> GetAllResidentsByAsync()
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<Resident?>> GetAllResidentsByBuildingAndApt(string building, string apt)
    {
        throw new NotImplementedException();
    }

    public async Task<Resident?> GetResidentsByCPFAsync(string cpf)
    {
        return await context.Residents.FirstOrDefaultAsync(resident => resident.Cpf == cpf);
    }

    public async Task<Resident?> GetResidentsByIdAsync(int id)
    {
        return await context.Residents.FirstOrDefaultAsync(resident => resident.Id == id);
    }
}
