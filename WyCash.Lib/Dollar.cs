namespace WyCash.Lib
{
    public class Dollar
    {
        private int _amount;

        public Dollar(int amount)
        {
            this._amount = amount;
        }

        public Dollar Times(int multipier)
        {
            return new Dollar(_amount * multipier);
        }

        public override bool Equals(object obj)
        {
            Dollar dollar = (Dollar) obj;
            return _amount == dollar._amount;
        }
    }
}