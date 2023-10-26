using BankServices.Data;
using BankServices.models;

namespace BankServices.Services
{
    public class AccountService : IAccountService
    {
        private readonly BankDbContext _dbcontext;
        public AccountService(BankDbContext dbcontext)
        {
            _dbcontext = dbcontext;
            
        }
        public void CreateAccount(Account account)
        {
            if (account == null)
            {
                throw new ArgumentNullException(nameof(account));
            }
            var existinga=_dbcontext.Accounts.Where(a=>a.accountid.Equals(account.accountid)).FirstOrDefault();     
            if (existinga == null)
            {
                var newAccount = new Account
                {
                    accountid = account.accountid,
                    accountnumber = account.accountnumber,
                    balance = account.balance,
                    customerid = account.customerid,
                    bankid = account.bankid,
                };
                _dbcontext.Accounts.Add(newAccount);
                _dbcontext.SaveChanges();
            }
            else
            {
                Console.WriteLine("already exist");
            }

           

        }

        public void DeleteAccountById(int accountid)
        {
            throw new NotImplementedException();
        }

        public Account GetAccountById(int accountid)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Account> GetAllAccounts(int customerid)
        {
            throw new NotImplementedException();
        }

        public void UpdateAccount(Account account)
        {
            throw new NotImplementedException();
        }
    }
}
