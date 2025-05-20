using CondoBox.Applications.Persist.Interface;
using CondoBox.Applications.Validator.Exceptions.CPF;
using CondoBox.Applications.Validator.Exceptions.Login;
using CondoBox.Domain;
using CondoBox.Infrastructure.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CondoBox.Applications.Persist;

public class EmployeePersist : IEmployeePersist
{
    private readonly IGenericRepository generic;
    private readonly IEmployeeRepository repository;

    public EmployeePersist(IGenericRepository generic, IEmployeeRepository repository)
    {
        this.generic = generic;
        this.repository = repository;
    }

    public async Task<bool> AddEmployeeAsync(Employee model)
    {
        try
        {
            var exists = await repository.GetEmployeeByCPFAsync(model.Cpf);
            if (exists != null)
                throw new InvalidCPFException("CPF já cadastrado.");
            generic.Add(model);
            return await generic.SaveChangesAsync();
        }
        catch (InvalidCPFException)
        {
            throw;
        }
    }
    public async Task<bool> UpdateEmployeeAsync(int id, Employee model)
    {
        try
        {
            var employee = repository.GetEmployeeByIdAsync(id);
            if (employee == null) return false;
            model.Id = employee.Id;
            generic.Update<Employee>(model);
            return await generic.SaveChangesAsync();
        }
        catch (Exception)
        {
            throw new Exception("Erro ao atualizar o Colaborador");
        }
    }

    public async Task<bool> DeleteEmployeeAsync(int id)
    {
        try
        {
            var employee = repository.GetEmployeeByIdAsync(id);
            if (employee == null) return false;
            generic.Delete(employee);
            return await generic.SaveChangesAsync();
        }
        catch (Exception)
        {
            throw new Exception("Erro ao deletar o Colaborador");
        }
    }

    public async Task<IEnumerable<Employee>> GetAllEmployeeAsync()
    {
        try
        {
            var employees = await repository.GetAllEmployeeAsync();
            return employees;
        }
        catch (Exception)
        {
            throw new Exception("Erro ao listar todos os Colaborador");
        }
    }

    public async Task<Employee> GetEmployeeByCpfAsync(string cpf)
    {
        try
        {
            return await repository.GetEmployeeByCPFAsync(cpf);
        }
        catch (Exception ex)
        {
            throw new Exception("Erro ao Buscar Colaborador.");
        }
        
    }

    public async Task<Employee> GetEmployeeByIdAsync(int id)
    {
        throw new NotImplementedException();
    }
}
