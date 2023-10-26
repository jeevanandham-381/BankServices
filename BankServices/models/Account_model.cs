namespace BankServices.models
{
    public class Account_model
    {
        public int accountid { get; set; }
        public string accountnumber { get; set; }
        public decimal balance { get; set; }
        public int customerid { get; set; }
    }
}
