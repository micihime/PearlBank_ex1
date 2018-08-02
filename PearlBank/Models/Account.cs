namespace PearlBank.Models
{
    public abstract class Account : IAccount
    {
        #region Private Frields

        private static decimal minIncome = 10;
        private static int minAge = 10;
        private static int maxAge = 100;

        // private member data 
        private string name;
        private string address;
        private int age;
        private decimal balance;
        private AccountState state;
        #endregion

        #region Properties

        public AccountState State { get; set; }
        #endregion

        #region Constructors

        public Account (string inName, string inAddress, decimal inBalance)
        {
            name = inName;
            address = inAddress;
            balance = inBalance;
            state = AccountState.New;
        }

        public Account(string inName, string inAddress) : this(inName, inAddress, 0) { }

        public Account(string inName) : this(inName, "Not Supplied", 0) { }
        #endregion

        #region Methods

        /// <summary>
        /// Sets the age.
        /// </summary>
        /// <param name="inAge">The in age.</param>
        /// <returns></returns>
        public bool SetAge(int inAge)
        {
            if ((inAge > minAge) && (inAge < maxAge))
            {
                this.age = inAge;
                return true;
            }

            return false;
        }

        /// <summary>
        /// Accounts the allowed.
        /// </summary>
        /// <param name="income">The income.</param>
        /// <param name="age">The age.</param>
        /// <returns></returns>
        public static bool AccountAllowed(decimal income, int age)
        {
            if ((income >= minIncome) && (age >= minAge))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Pays the in funds.
        /// </summary>
        /// <param name="amount">The amount.</param>
        public void PayInFunds(decimal amount)
        {
            balance = balance + amount;
        }

        /// <summary>
        /// Withdraws the funds.
        /// </summary>
        /// <param name="amount">The amount.</param>
        /// <returns></returns>
        public virtual bool WithdrawFunds(decimal amount)
        {
            if (balance < amount)
            {
                return false;
            }
            balance = balance - amount;
            return true;
        }

        /// <summary>
        /// Gets the balance.
        /// </summary>
        /// <returns></returns>
        public decimal GetBalance()
        {
            return balance;
        }

        /// <summary>
        /// Rudes the letter string.
        /// </summary>
        /// <returns></returns>
        public abstract string RudeLetterString();

        public override string ToString()
        {
            return "Name: " + name + ", balance: " + balance;
        }
        #endregion
    }
}