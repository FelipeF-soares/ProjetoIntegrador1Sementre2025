using CondoBox.Applications.Persist.Interface;
using CondoBox.Applications.Validator.Exceptions;
using CondoBox.Domain;
using CondoBox.Infrastructure.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CondoBox.Applications.Persist;

public class UnitPersist : IUnitPersist
{
    private readonly IUnitRepository repository;

    public UnitPersist(IUnitRepository repository)
    {
        this.repository = repository;
    }
    public async Task<IEnumerable<Unit>> GetAllUnityAsync()
    {
        try
        {
            var units = await repository.GetAllUnitsAsync();
            if (!units.Any()) throw new Exception("Nenhuma unidade encontrada");
            return units;

        }
        catch(Exception ex)
        {
            throw;
        }
    }

    public Task<Unit> GetUnityBuldingAndApt(string unit, string apt)
    {
        throw new NotImplementedException();
    }

    public async Task<Unit> GetUnityById(int id)
    {
        try
        {
            var unit = repository.GetUnitByIdAsync(id);
            if (unit == null) throw new NotFoundException("Não foi localizado Unidade com esse Id");
            return await unit;
        }
        catch (Exception ex)
        {
            throw new Exception("Erro ao Encotrar Id");
        }
    }
}
