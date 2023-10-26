using BankServices.Data;
using BankServices.models;

namespace BankServices.Services
{
    public class BankService : IBankService
    {
        private readonly BankDbContext _dbcontext;
        public BankService(BankDbContext dbcontext)
        {
            _dbcontext = dbcontext; 
        }

      

        public void CreateBank(Bank bank)
        {
            if (bank == null)
            {
                throw new ArgumentNullException();
            }
            var existing=_dbcontext.Banks.Where(d => d.bankid.Equals(bank.bankid)).FirstOrDefault();
            if (existing == null)
            {
                _dbcontext.Banks.Add(bank);
                _dbcontext.SaveChanges();

            }
            else
            {
                Console.WriteLine("already exist");
            }
            
        }

        public void DeleteBankById(int bankid)
        {
            throw new NotImplementedException();
        }

        public void UpdateBank(Bank bank)
        {
            throw new NotImplementedException();
        }

       
    }
}
