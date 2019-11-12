namespace WyCash.Lib
{
    public class Dollar:Money
    {
        

        public Dollar(int amount)
        {
            this._amount = amount;
        }

        public override Money Times(int multipier)
        {
            return new Dollar(_amount * multipier);
        }

    }
}