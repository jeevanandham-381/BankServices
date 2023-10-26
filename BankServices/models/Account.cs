using System.ComponentModel.DataAnnotations.Schema;

namespace BankServices.models
{
    [Table("accounts")]
    public class Account
    {
        public int accountid { get; set; }
        public string accountnumber { get; set; }
        public decimal balance { get; set; }
        public int customerid { get; set; }
        //public Customer customer { get; set; }
        public int bankid { get; set; }
    }
}
