using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountProject
{
    public class CheckingAccount : Accounts
    {
        ////fields
        private string accountNumberChecking;
        private double balanceChecking;
        private string accountType;
        private double amountDeposit;
        private double amountWithdraw;


        //// Properties
        public string AccountNumberChecking
        {
            get { return this.accountNumberChecking; }
            set { this.accountNumberChecking = value; }
        }


        public double BalanceChecking
        {
            get { return this.balanceChecking; }
            set { this.balanceChecking = value; }
        }

        public string AccountType
        {
            get { return this.accountType; }
            set { this.accountType = value; }
        }

        public double AmountDeposit
        {
            get { return this.amountDeposit; }
            set { this.AmountDeposit = value; }
        }

        public double AmountWithdraw
        {
            get { return this.amountWithdraw; }
            set { this.amountWithdraw = value; }
        }



        //// Constructors
        public CheckingAccount()
        {
            this.accountNumberChecking = "1234 28";
            this.balanceChecking = 500;
        }

        public CheckingAccount(string accountNumberChecking, double balanceChecking, string accountType, double amountDeposit, double amountWithdraw)
        {
            this.accountNumberChecking = accountNumberChecking;
            this.balanceChecking = balanceChecking;
            this.accountType = accountType;
            this.amountDeposit = amountDeposit;
            this.amountWithdraw = amountWithdraw;
        }

        //// Methods

        //// View balance
        public void CheckingBalance()
        {
            Console.WriteLine("Current Balance: " + balanceChecking);
        }


        //// Making a deposit



        //// Balance after a deposit
        public void BalanceAfterDeposit()
        {
            this.balanceChecking = balanceChecking + amountDeposit;
            Console.WriteLine("Current Balance: " + balanceChecking);
        }


        //// Balance afer a withdraw
        public void BalanceAfterWithdraw()
        {
            this.balanceChecking = balanceChecking - amountWithdraw;
            Console.WriteLine("Current balance: " + balanceChecking);
        }

    }
}
