namespace WyCash.Lib
{
    public class Dollar
    {
        public int amount;

        public Dollar(int amount)
        {
            this.amount = amount;
        }

        public Dollar Times(int multipier)
        {
            return new Dollar(amount * multipier);
        }
    }
}