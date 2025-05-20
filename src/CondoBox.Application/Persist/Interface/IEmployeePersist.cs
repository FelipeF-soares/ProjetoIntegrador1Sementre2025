using CondoBox.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CondoBox.Applications.Persist.Interface;

public interface IEmployeePersist
{
    Task<bool> AddEmployeeAsync(Employee model);
    Task<bool> UpdateEmployeeAsync(int id, Employee model);
    Task<bool> DeleteEmployeeAsync(int id);
    Task<IEnumerable<Employee>> GetAllEmployeeAsync();
    Task<Employee> GetEmployeeByCpfAsync(string cpf);
    Task<Employee> GetEmployeeByIdAsync(int id);
}
