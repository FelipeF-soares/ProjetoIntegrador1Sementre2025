using CondoBox.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CondoBox.Applications.Validator.EmployeeValid.Interface;

public interface IEmployeeValid
{
    Employee Valid(
        string fullName, 
        string cpf, 
        string role,
        string cellPhone,
        string password, 
        string confirmPassword, 
        string pathImage
        );

}
