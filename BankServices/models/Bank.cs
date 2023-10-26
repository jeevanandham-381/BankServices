using System.ComponentModel.DataAnnotations.Schema;

namespace BankServices.models
{
    [Table("banks")]
    public class Bank
    {
        public int bankid { get; set; }
        public string bankname { get; set; } = string.Empty;
        public string location { get; set; } = string.Empty;
       // public ICollection<Account> accounts {get;set;}
    }
}
