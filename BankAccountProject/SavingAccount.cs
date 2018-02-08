using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountProject
{
    public class SavingAccount : Accounts
    {
        //// fields
        private string accountNumberSavings;
        private double balanceSavings;
        private string accountType;
        private double amountDeposit;
        private double amountWithdraw;


        //// Properties
        public string AccountNumberSavings
        {
            get { return this.accountNumberSavings; }
            set { this.accountNumberSavings = value; }
        }

        public double BalanceSavings
        {
            get { return this.balanceSavings; }
            set { this.balanceSavings = value; }
        }

        public string AccountType
        {
            get { return this.accountType; }
            set { this.accountType = value; }
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


        //// Constructor
        public SavingAccount()
        {
            this.accountNumberSavings = "1234 34";
            this.balanceSavings = 300;
        }

        public SavingAccount(string accountNumberSavings, double balanceSavings, string accountType, double amountDeposit, double amountWithdraw)
        {
            this.accountNumberSavings = accountNumberSavings;
            this.balanceSavings = balanceSavings;
            this.accountType = accountType;
            this.amountDeposit = amountDeposit;
            this.amountWithdraw = amountWithdraw;
        }


        //// Methods
        
        //// View balance
        public void SavingsBalance()
        {
            Console.WriteLine("Current Balance: " + balanceSavings);
        }

        //// Making a Deposit
        
        //// Balance after Deposit
        public void BalanceAFterDeposit()
        {
            this.balanceSavings = balanceSavings + amountDeposit;
            Console.WriteLine("Current Balance: " + balanceSavings);
        }

        //// Balance after Withdraw
        public void BalanceAfterWithdraw()
        {
            this.balanceSavings = balanceSavings - amountWithdraw;
            Console.WriteLine("Current Balance: " + balanceSavings);
        }





    }
}
