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

public class EmployeeRepository : IEmployeeRepository
{
    private readonly AppDbContext context;

    public EmployeeRepository(AppDbContext context)
    {
        this.context = context;
    }
    public async Task<IEnumerable<Employee>> GetAllEmployeeAsync()
    {
        return await context.Employees.ToListAsync();
    }

    public async Task<Employee?> GetEmployeeByCPFAsync(string cpf)
    {
        IQueryable<Employee> query = context.Employees.Where(employee => employee.Cpf == cpf);

        return await query.FirstOrDefaultAsync();
    }

    public async Task<Employee?> GetEmployeeByIdAsync(int id)
    {
        IQueryable<Employee> query = context.Employees.Where(employee => employee.Id == id);
        return await query.FirstOrDefaultAsync();
    }
}
