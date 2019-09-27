namespace WyCash.Tests
{
    public class Franc
    {
        private  int _amount;

        public Franc(int amount)
        {
            _amount = amount;
        }

        public Franc Times(int multiplier)
        {
            return  new Franc(_amount * multiplier);
        }

        public override bool Equals(object obj)
        {
            Franc franc = (Franc) obj;
            return franc._amount == _amount;
        }
    }
}