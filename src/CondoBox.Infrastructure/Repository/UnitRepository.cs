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

public class UnitRepository : IUnitRepository
{
    private readonly AppDbContext context;

    public UnitRepository(AppDbContext context)
    {
        this.context = context;
    }
    public async Task<IEnumerable<Unit>> GetAllUnitsAsync()
    {
        var query = context.Units.Include(resident => resident.Residents).AsNoTracking();


        return await query.ToListAsync();
    }

    public Task<Unit> GetUnitByBuldingAndApt(string bulding, string apt)
    {
        throw new NotImplementedException();
    }

    public async Task<Unit?> GetUnitByIdAsync(int id)
    {
        var query = context.Units.Include(resident => resident.Residents).AsNoTracking();

        return await query.FirstOrDefaultAsync(unit => unit.Id == id);
    }
}
