using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CondoBox.Domain;

public class Mail
{
    public int Id { get; set; }
    public DateTime DateTimeRegister { get; set; }
    public string CpfEmployee { get; set; }
    public string NameEmployee { get; set; }
    public int Amount { get; set; }
    public Unit Unit { get; set; }
    public int UnitId { get; set; }
}
