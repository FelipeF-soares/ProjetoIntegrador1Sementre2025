using BrazilianUtils;
using CondoBox.Applications.Persist.Interface;
using CondoBox.Applications.Validator.Exceptions.Login;
using CondoBox.Applications.Validator.Exceptions.Password;
using CondoBox.Domain;
using CondoBox.Infrastructure.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CondoBox.Applications.Login;

public class LoginService
{
    public bool Authenticate(string cpf, string password, Employee employee)
    {
        if (employee == null) throw new InvalidLoginException("Usuário não localizado.");
        if(!PasswordHasher.Verify(password, employee.PasswordHash)) throw new InvalidLoginException("Usuário ou senha não localizado");

        return true;
    }

    public Employee EmployeeResult(string cpf, IEmployeePersist persist)
    {
        var employe = persist.GetEmployeeByCpfAsync(cpf).Result;
        return employe;
    }
}
