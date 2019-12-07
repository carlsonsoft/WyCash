namespace WyCash.Lib
{
    public interface IBankExpression
    {
        Money Reduce(string to);
    }
}