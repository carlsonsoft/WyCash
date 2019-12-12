namespace WyCash.Lib
{
    public class Money : IBankExpression
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
            return new Money(amount, "USD");
        }

        public static Money Franc(int amount)
        {
            return new Money(amount, "CHF");
        }

        public override bool Equals(object obj)
        {
            Money money = (Money) obj;
            return Amount == money.Amount && Currency() == money.Currency();
        }

        public string Currency()
        {
            return _currency;
        }

        public override string ToString()
        {
            return $"{Amount}-{_currency}";
        }

        public Money Reduce(Bank bank, string to)
        {
            int rate = bank.Rate(_currency, to);
            return new Money(Amount / rate, to);
        }


        public IBankExpression Plus(IBankExpression addend)
        {
            return new Sum(this, addend);
        }

        public IBankExpression Times(int multiplier)
        {
            return new Money(Amount * multiplier, _currency);
        }
    }
}