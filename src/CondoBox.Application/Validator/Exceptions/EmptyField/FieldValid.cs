using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CondoBox.Applications.Validator.Exceptions.EmptyField;

public static class FieldValid
{
    public static void IsEmptyOrWhiteSpace(string value)
    {
        if (string.IsNullOrWhiteSpace(value))
            throw new InvalidFieldException("Campo não pode estar vazio.");
    }
}
