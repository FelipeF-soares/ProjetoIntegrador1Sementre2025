using CondoBox.Applications.Validator.Exceptions.CPF;
using CondoBox.Applications.Validator.ResidentValid.Interface;
using CondoBox.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CondoBox.Applications.Validator.ResidentValid;

public class ResidentValid : IResidentValid
{
    public Resident IsValid(string fullName, string cpf, string email, string cellPhone, int unitId)
    {
        CpfValidator.IsValid(cpf.Trim());

        var resident = new Resident();
        resident.Name = fullName.ToUpper().Trim();
        resident.Cpf = cpf.Trim();
        resident.CellPhone = cellPhone.Trim();
        resident.Email = email.Trim();
        resident.UnitId = unitId;

        return resident;
    }
}
