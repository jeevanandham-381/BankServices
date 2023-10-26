using BankServices.models;

namespace BankServices.Services
{
    public interface IBankService
    {

        void CreateBank(Bank bank);
        void UpdateBank(Bank bank);
        void DeleteBankById(int bankid);
    }
}
