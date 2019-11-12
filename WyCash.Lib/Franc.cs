using WyCash.Lib;

namespace WyCash.Tests
{
    public class Franc:Money
    {
        public Franc(int amount)
        {
            _amount = amount;
        }

        public override Money Times(int multiplier)
        {
            return  new Franc(_amount * multiplier);
        }

    }
}