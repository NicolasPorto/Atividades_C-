namespace LearningHeranca.Entities
{
    internal class SavingAccount : Account
    {

        public double InterestRate { get; set; }

        public SavingAccount()
        {
        }

        public SavingAccount(int number, string holder, double balance, double InterestRate) : base(number, holder, balance)
        {

            InterestRate = InterestRate;

        }

        public void UpdateBalance()
        {

            Balance += Balance * InterestRate;
        }

        public override void Withdraw(double amount)
        {
            base.Withdraw(amount);
            Balance -= 2.0;
        }


    }
}
