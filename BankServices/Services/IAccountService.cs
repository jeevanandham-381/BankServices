using BankServices.models;

namespace BankServices.Services
{
    public interface IAccountService
    {
        Account GetAccountById(int accountid);
        void CreateAccount (Account account);
        void UpdateAccount (Account account);
        void DeleteAccountById (int accountid);

        IEnumerable<Account> GetAllAccounts (int customerid);
    }
}
