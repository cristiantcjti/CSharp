using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_ByteBank
{
    public class InsufficientBalanceException : Exception
    {
        public double Balance { get; }
        public double WithdrawValue { get; }


        public InsufficientBalanceException()
        {

        }
        public InsufficientBalanceException(double balance, double withdrawValue)
            : this("Attempt to withdraw " + withdrawValue + " from a balance of "+ balance)
        {
            Balance = balance;
            WithdrawValue = withdrawValue;

        }
        public InsufficientBalanceException(string message):base(message)
        {

        }
    }
}
