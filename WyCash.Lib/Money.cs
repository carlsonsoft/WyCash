using WyCash.Tests;

namespace WyCash.Lib
{
    public abstract class Money
    {
        protected int _amount;

        public static Money CreateDollar(int amount)
        {
            return new Dollar(amount);
        }
        public static Money CreateFranc(int amount)
        {
            return new Franc(amount);
        }

        public override bool Equals(object obj)
        {
            Money money = (Money)obj;
            return _amount == money._amount && money.GetType() == this.GetType();
        }

        public abstract Money Times(int multiplier);
    }
}