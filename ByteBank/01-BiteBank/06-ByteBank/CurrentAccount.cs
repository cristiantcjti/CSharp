
namespace _06_ByteBank
{
    public class CurrentAccount
    {
        //private Client _holder; Don't need to declare because it is a encapsulated variable now.

        public  Client Holder {get;set;} // when we do not have any logic
        public int Agency { get; set; }
        public int Number { get; set; }
        private double _balance = 100; // _variable name, because it is a encapsulated variable.

        public double Balance // first letter UPPER CASE
        {
            get
            {
                return _balance; 
            }
            set
            {
                if (value < 0)
                {
                    return;
                }
                _balance = value;
            }
        }

        public bool Withdraw(double value)
        {
            if (this._balance < value)
            {
                return false;
            }
            else
            {
                this._balance -= value;
                return true;
            }
        }

        public void Deposit(double value)
        {
            this._balance += value;
        }

        public bool Transfer(double value, CurrentAccount targetAccount)
        {
            if (this._balance < value)
            {
                return false;
            }
            this._balance -= value;
            targetAccount.Deposit(value);
            return true;
        }
    }
}



