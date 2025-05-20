using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CondoBox.Domain;

public class Unit
{
    public int Id { get; set; }
    public string  Building { get; set; } = string.Empty;
    public string  Apt { get; set; } = string.Empty;
    public ICollection<Resident> Residents { get; set; } = new List<Resident>();
    public ICollection<Mail> Mails { get; set; } = new List<Mail>();

    public string Description => $"{Building} - Apto: {Apt}";
}
