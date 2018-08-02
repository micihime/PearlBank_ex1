namespace PearlBank.Models
{
    public sealed class BabyAccount : Account
    {
        private string parentName;

        public string ParentName { get; }

        public BabyAccount(string inName, string inAddress, decimal inBalance, string parentName) : base(inName, inAddress, inBalance)
        {
            this.parentName = parentName;
        }

        public override bool WithdrawFunds(decimal amount)
        {
            if (amount > 10)
            {
                return false;
            }

            return base.WithdrawFunds(amount);
        }

        public override string RudeLetterString()
        {
            return "Tell daddy you are overdrawn";
        }

        public override string ToString()
        {
            return base.ToString() + " Parent: " + parentName;
        }
    }
}
