using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountProject
{
    public class Accounts
    {
        //// fields

        //// account number
        private string accountNumber;

        
        ////types of accounts
        public string accountType;


        //// balances
        private double accountBalance;


        //// types of account activity
        public double amountDeposit;
        public double amountWithdraw;

        
        //// Propterties

        public string AccountNumber
        {
            get { return this.accountNumber; }
            set { this.accountNumber = value; }
        }

        public string AccountType
        {
            get { return this.accountType; }
            set { this.accountType = value; }
        }


        public double AccountBalance
        {
            get { return this.accountBalance; }
            set { this.accountBalance = value; }
        }

        
        public double AmountDeposit
        {
            get { return this.amountDeposit; }
            set { this.amountDeposit = value; }
        }

        public double AmountWithdraw
        {
            get { return this.amountWithdraw; }
            set { this.amountWithdraw = value; }
        }   


        //// Constructors
        public Accounts()
        {
            this.accountNumber = "1234";
        }

        public Accounts(string accountNumber, string accountType, double accountBalance, double amountDeposit, double amountWithdraw)
        {
            this.accountNumber = accountNumber;
            this.accountType = accountType;
            this.accountBalance = accountBalance;
            this.amountDeposit = amountDeposit;
            this.amountWithdraw = amountWithdraw;
            
        }


    }
}
