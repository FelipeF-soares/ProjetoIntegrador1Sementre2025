using CondoBox.Applications.Validator.EmployeeValid.Interface;
using CondoBox.Applications.Validator.Exceptions.CPF;
using CondoBox.Applications.Validator.Exceptions.EmptyField;
using CondoBox.Applications.Validator.Exceptions.Password;
using CondoBox.Applications.Validator.Placeholder;
using CondoBox.Domain;

namespace CondoBox.Applications.Validator.EmployeeValid;

public class EmployeeValid : IEmployeeValid
{
    public Employee Valid(string fullName, string cpf, string role, string cellPhone, string password, string confirmPassword, string pathImage)
    {

        Employee employee = new Employee();
        PasswordValidator.Validate(password.Trim(), confirmPassword.Trim());
        FieldValid.IsEmptyOrWhiteSpace(cpf);
        CpfValidator.IsValid(cpf.Trim());
        FieldValid.IsEmptyOrWhiteSpace(fullName);
        FieldValid.IsEmptyOrWhiteSpace(role);
        FieldValid.IsEmptyOrWhiteSpace(cellPhone);

        employee.Name = fullName.ToUpper().Trim();
        employee.Cpf = CPFMask.Remove(cpf).Trim();
        employee.Role = role.ToUpper().Trim();
        employee.CellPhone = CellPhoneMask.Remove(cellPhone).Trim();
        employee.ImagePath = pathImage;
        employee.PasswordHash = PasswordHasher.Hash(password.Trim());

        return employee;
    }
}