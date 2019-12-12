namespace WyCash.Lib
{
    public interface IBankExpression
    {
        Money Reduce(Bank bank,string to);
        IBankExpression Plus(IBankExpression addend);
        IBankExpression Times(int multiplier);
    }
}