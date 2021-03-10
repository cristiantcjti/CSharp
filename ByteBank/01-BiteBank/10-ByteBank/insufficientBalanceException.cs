using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_ByteBank
{
    public class InsufficientBalanceException : FinancialOperationException
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

        public InsufficientBalanceException(string message, Exception internalException) : base(message, internalException)
        {

        }
    }
}
