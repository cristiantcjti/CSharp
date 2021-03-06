﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_ByteBank
{
    public class CurrentAccount
    {
        //private Client _holder; Don't need to declare because it is a encapsulated variable now.

        public  Client Holder {get;set;} // when we do not have any logic

        public static int TotalCreatedAccounts { get; private set; }

        public int Number { get; } // it creates a private readonly field that only allows to set a value to Number inside a Constructor.  

        public int Agency { get; } // it creates a private readonly field that only allows to set a value to Number inside a Constructor. 

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

        //Constructor
        public CurrentAccount(int agency, int number)
        {
            if( agency <= 0 )
            {
                ArgumentException exception = new ArgumentException("The Agency's code can not be 0!");
                throw exception;
            }
            if ( number <= 0)
            {
                ArgumentException exception = new ArgumentException("The Number's code can not be 0!");
                throw exception;
            }

            Agency = agency;
            Number = number;
            TotalCreatedAccounts++;
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



