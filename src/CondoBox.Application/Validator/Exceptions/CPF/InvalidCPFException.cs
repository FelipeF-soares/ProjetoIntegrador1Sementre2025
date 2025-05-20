using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CondoBox.Applications.Validator.Exceptions.CPF;

public class InvalidCPFException : Exception
{
    public InvalidCPFException(string message) : base (message)
    {
        
    }
}
