using System.Text.RegularExpressions;

namespace CondoBox.Applications.Validator.Placeholder;

public static class CPFMask
{
    public static string Remove(string cpf)
    {
        return Regex.Replace(cpf, @"\D","");
    }

    public static string Add(string cpf)
    {
        cpf = Remove(cpf);

        return Convert.ToUInt64(cpf).ToString(@"000\.000\.000\-00");
    }

}
