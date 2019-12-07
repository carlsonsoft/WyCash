namespace WyCash.Lib
{
    public class Sum : IBankExpression
    {
        public Money Augend;
        public Money Addend;

        public Sum(Money augend, Money addend)
        {
            Augend = augend;
            Addend = addend;
        }
        public Money Reduce(string to)
        {
            int amount = Addend.Amount + Augend.Amount;
            return new Money(amount,to);
        }

    }
}