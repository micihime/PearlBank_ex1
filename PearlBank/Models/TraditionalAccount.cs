namespace PearlBank.Models
{
    public sealed class TraditionalAccount : Account
    {
        public TraditionalAccount(string inName, string inAddress, decimal inBalance) : base(inName, inAddress, inBalance) { }

        public override string RudeLetterString()
        {
            return "You are overdrawn";
        }
    }
}
