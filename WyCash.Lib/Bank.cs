namespace WyCash.Lib
{
    public class Bank
    {
        public Money Reduce(IBankExpression source, string to)
        {
            return source.Reduce(to);
        }
    }
}