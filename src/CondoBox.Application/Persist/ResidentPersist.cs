using CondoBox.Applications.Persist.Interface;
using CondoBox.Applications.Validator.Exceptions;
using CondoBox.Applications.Validator.Exceptions.CPF;
using CondoBox.Domain;
using CondoBox.Infrastructure.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CondoBox.Applications.Persist;

public class ResidentPersist : IResidentPersist

{
    private readonly IGenericRepository generic;
    private readonly IResidentRepository repository;

    public ResidentPersist(IGenericRepository generic, IResidentRepository repository)
    {
        this.generic = generic;
        this.repository = repository;
    }
    public async Task<bool> AddResisdentAsync(Resident model)
    {
        try
        {
            var exist = await repository.GetResidentsByCPFAsync(model.Cpf.Trim());
            if (exist != null) throw new InvalidCPFException("CPF já cadastrado");
            generic.Add(model);
            return await generic.SaveChangesAsync();
        }
        catch (InvalidCPFException ex)
        {
            throw;
        }
    }
    public async Task<bool> UpdateResisdentAsync(int id, Resident model)
    {
        try
        {
            var resident = await repository.GetResidentsByIdAsync(id);
            if (resident == null) return false;
            model.Id = resident.Id;
            generic.Update(model);
            return await generic.SaveChangesAsync();
        }
        catch (Exception)
        {
            throw new Exception("Erro ao Atualizar Morador");
        }
    }

    public async Task<bool> DeleteResisdentAsync(int id)
    {
        try
        {
            var resident = await repository.GetResidentsByIdAsync(id);
            if (resident == null) return false;
            generic.Delete(resident);
            return await generic.SaveChangesAsync();
        }
        catch (Exception)
        {
            throw new Exception("Erro ao Deletar Morador");
        }
    }

    public Task<IEnumerable<Resident>> GetAllResidentsAsync()
    {
        throw new NotImplementedException();
    }

    public Task<Resident> GetResidentByCpfAsync(string cpf)
    {
        throw new NotImplementedException();
    }

    public async Task<Resident> GetResidentByIdAsysnc(int id)
    {
        try
        {
            var resident = await repository.GetResidentsByIdAsync(id);
            if (resident == null) throw new NotFoundException("Morador não localizado.");
            return resident;
        }
        catch (Exception)
        {
            throw new Exception("Erro ao buscar Morador por ID");
        }
    }
}
