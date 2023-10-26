using System.ComponentModel.DataAnnotations.Schema;

namespace BankServices.models
{
    [Table("customers")]
    public class Customer
    {
        public int customerid { get; set; }
        public string name { get; set; }
        public string email { get; set; }
        public string phone { get; set; }
        public ICollection<Account> accounts { get; set; }

    }
}
