using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace CondoBox.Applications.Validator.Exceptions;

public class NotFoundException : Exception
{
    public NotFoundException(string message) : base (message)
    {
        
    }
}
