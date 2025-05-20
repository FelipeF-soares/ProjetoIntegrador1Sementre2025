using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CondoBox.Domain;

public class Resident
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Cpf { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public string CellPhone { get; set; } = string.Empty;
    public int UnitId { get; set; }
    public Unit Unit { get; set; } = null!;
}
