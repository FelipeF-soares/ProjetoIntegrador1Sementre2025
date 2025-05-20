using CondoBox.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CondoBox.Applications.Persist.Interface;

public interface IUnitPersist
{
    Task<IEnumerable<Unit>> GetAllUnityAsync();
    Task<Unit> GetUnityBuldingAndApt(string unit, string apt);
    Task<Unit> GetUnityById(int id);
}
