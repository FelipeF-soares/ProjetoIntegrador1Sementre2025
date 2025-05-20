using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CondoBox.Applications.Validator.Placeholder;

public static class CellPhoneMask
{
    public static string Remove(string cellphone)
    {
        return Regex.Replace(cellphone, @"\D", "");
    }

    public static string Add(string cellphone)
    {
        cellphone = Remove(cellphone);
        return Convert.ToUInt64(cellphone).ToString(@"\(00\)00000\-0000");
    }
}
