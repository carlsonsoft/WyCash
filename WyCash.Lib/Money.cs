

namespace WyCash.Lib
{
    public class Money:IBankExpression
    {
        public int Amount;
        public string _currency;

        public Money(int amount, string currency)
        {
            Amount = amount;
            _currency = currency;
        }

        public static Money Dollar(int amount)
        {
            return new Money(amount,"USD");
        }
        public static Money Franc(int amount)
        {
            return new Money(amount, "CHF");
        }

        public override bool Equals(object obj)
        {
            Money money = (Money)obj;
            return Amount == money.Amount && Currency()==money.Currency();
        }

        public Money Times(int multipier)
        {
            return new Money(Amount * multipier, _currency);
        }

        public string Currency()
        {
            return _currency;
        }

        public override string ToString()
        {
            return $"{Amount}-{_currency}";
        }

        public Money Reduce(string to)
        {
            return this;
        }


        public IBankExpression Plus(Money addend)
        {
            return new Sum(this,addend);
        }
    }
}