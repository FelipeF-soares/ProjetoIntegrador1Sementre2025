using CondoBox.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CondoBox.Applications.Validator.ResidentValid.Interface;

public  interface IResidentValid
{
    Resident IsValid(
        string fullName,
        string cpf,
        string email,
        string cellPhone,
        int unitId
        );

}
