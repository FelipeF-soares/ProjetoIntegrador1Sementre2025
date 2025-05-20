using CondoBox.Applications.Persist.Interface;
using CondoBox.Applications.Validator.Exceptions.CPF;
using CondoBox.Applications.Validator.Exceptions.EmptyField;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CondoBox.Applications.Login;

public static class LoginValid
{
    public static void CheckValided(string cpf, string password)
    {
        FieldValid.IsEmptyOrWhiteSpace(cpf);
        FieldValid.IsEmptyOrWhiteSpace(password);
        CpfValidator.IsValid(cpf);
    }

}
