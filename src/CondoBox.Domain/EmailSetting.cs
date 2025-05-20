using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CondoBox.Domain;

public class EmailSetting
{
    public int Id { get; set; }
    public string EmailSender { get; set; }
    public string CryptoPassword { get; set; }
    public string SmtpClient { get; set; }
    public string SmtpPort { get; set; }
    public string EmailCC { get; set; }
    public string EmailSubject { get; set; }
    public string EmailBody { get; set; }
    
   

}
