using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CondoBox.Domain;

public class Employee
{
    
    public int Id { get; set; }
    public string Role { get; set; } = string.Empty;
    public string Cpf { get; set; } = string.Empty;
    public string Name { get; set; } = string.Empty;
    public string CellPhone { get; set; } = string.Empty;
    public string PasswordHash { get; set; } = string.Empty;
    public string ImagePath { get; set; } = string.Empty;

}
