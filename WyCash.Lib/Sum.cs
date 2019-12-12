namespace WyCash.Lib
{
    public class Sum : IBankExpression
    {
        public IBankExpression Augend;
        public IBankExpression Addend;

        public Sum(IBankExpression augend, IBankExpression addend)
        {
            Augend = augend;
            Addend = addend;
        }

        public Money Reduce(Bank bank, string to)
        {
            int amount = Addend.Reduce(bank, to).Amount + Augend.Reduce(bank, to).Amount;
            return new Money(amount, to);
        }

        public IBankExpression Plus(IBankExpression addend)
        {
            return new Sum(this, addend);
        }

        public IBankExpression Times(int multiplier)
        {
            return new Sum(Augend.Times(multiplier), Addend.Times(multiplier));
        }
    }
}