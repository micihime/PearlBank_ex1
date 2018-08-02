namespace PearlBank.Models
{
    public interface IAccount
    {
        AccountState State { get; set; }

        //bool AccountAllowed(decimal income, int age); //static

        void PayInFunds(decimal amount);
        bool WithdrawFunds(decimal amount);
        decimal GetBalance();

        string RudeLetterString();
    }
}
