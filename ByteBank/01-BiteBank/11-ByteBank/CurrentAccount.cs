using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_ByteBank
{
    public class CurrentAccount
    {
        //private Client _holder; Don't need to declare because it is a encapsulated variable now.

        private static int OperationTax;

        public static int TotalCreatedAccounts { get; private set; }

        public Client Holder { get; set; } // when we do not have any logic

        public int WithdrawNotAllowCounter { get; private set; }
        public int TranferNotAllowCounter { get; private set; }


        // NUMBER'S CODE
        public int Number { get; } // it creates a private readonly field that only allows to set a value to Number inside a Constructor.  

        // AGENCY'S CODE
        public int Agency { get; } // it creates a private readonly field that only allows to set a value to Number inside a Constructor. 

        // BALANCE
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

        //CONSTRUCTOR
        public CurrentAccount(int agency, int number)
        {
            if( agency <= 0 )
            {
                
                throw new ArgumentException("The Agency's code can not be 0!",nameof(agency));
            }
            if ( number <= 0)
            {
                
                throw new ArgumentException("The Number's code can not be 0!",nameof(number));
            }

            Agency = agency;
            Number = number;
            TotalCreatedAccounts++;
            OperationTax = 30 / TotalCreatedAccounts;
        }

        // WITHDRAW MONEY
        public void Withdraw(double value)
        {
            if (value < 0)
            {
                throw new ArgumentException("Invalid value to be withdraw.", nameof(value));
            }

            if (this._balance < value)
            {
                WithdrawNotAllowCounter++;
                throw new InsufficientBalanceException( Balance, value);
            }
            _balance -= value;
        }
        
        // DEPOSIT MONEY 
        public void Deposit(double value)
        {
            this._balance += value;
        }

        // TRANSFER MONEY
        public void Transfer(double value, CurrentAccount targetAccount)
        {
            if (value < 0)
            {
                throw new ArgumentException("Invalid value to be transfered.", nameof(value));
            }
            

            try
            {
                Withdraw(value);
            }
            catch(InsufficientBalanceException ex)
            {
                TranferNotAllowCounter++;
                throw new FinancialOperationException("Operation not carried out", ex);
            }

            targetAccount.Deposit(value);
        }
    }
}



