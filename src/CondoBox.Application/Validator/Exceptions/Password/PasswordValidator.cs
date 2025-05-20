using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CondoBox.Applications.Validator.Exceptions.Password;

public static class PasswordValidator
{
    public static void Validate(string password, string confirmPassword)
    {
        if (string.IsNullOrWhiteSpace(password))
            throw new InvalidPasswordException("Senha Não Pode estar vazia.");
        if (password.Length < 6)
            throw new InvalidPasswordException("Senha não pode ser menor que 6 caracteres.");
        if (!HasUpperCase(password))
            throw new InvalidPasswordException("Senha deve conter pelo menos um caracter em Maisculo.");
        if (!HasSymbol(password))
            throw new InvalidPasswordException("Senha deve conter pelo menos um Símbolos.");
        if (!HasDigit(password))
            throw new InvalidPasswordException("Senha deve conter pelo menos um Numero.");
        if (password != confirmPassword)
            throw new InvalidPasswordException("Senha com valores diferentes.");
    }
    private static bool HasUpperCase(string password)
    {
        return password.Any(char.IsUpper);
    }

    private static bool HasSymbol(string password)
    {
        return password.Any(ch => !char.IsLetterOrDigit(ch));
    }

    private static bool HasDigit(string password)
    {
        return password.Any(char.IsDigit);
    }
}
