public class CurrentAccount
{
    public string holder;
    public int agency;
    public int number;
    public double balance = 100;

    public bool Withdraw(double value)
    {
        if (this.balance < value)
        {
            return false;
        }
        else
        {
            this.balance -= value;
            return true;
        }
    }

    public void Deposit(double value)
    {
        this.balance += value;
    }

    public bool Transfer(double value, CurrentAccount targetAccount)
    {
        if (this.balance < value)
        {
            return false;
        }
        this.balance -= value;
        targetAccount.Deposit(value);
        return true;
    }
}

