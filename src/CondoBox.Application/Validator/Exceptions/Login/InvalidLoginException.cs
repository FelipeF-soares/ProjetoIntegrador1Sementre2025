using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CondoBox.Applications.Validator.Exceptions.Login;

public class InvalidLoginException : Exception
{
    public InvalidLoginException(string message) : base (message)
    {
        
    }
}
