using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CondoBox.Applications.Validator.Exceptions.CPF;

public static class CpfValidator
{
    public static void IsValid(string cpf)
    {
        if (!BrazilianUtils.Cpf.IsValid(cpf))
        throw new InvalidCPFException("Esse CPF não é um CPF válido.");
    }
}
