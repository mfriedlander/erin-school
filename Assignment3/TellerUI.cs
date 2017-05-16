using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    class TellerUI
    {
        BankAccount account = new BankAccount();
        public void Start()
        {
            WelcomeText();
        }

        private AccountTypes ReadAccountType()
        {
            char account;
            account = Input.ReadCharConsole("Would you like to access your Checking or Savings account? ( c / s )");
            Console.WriteLine("");

            if (account == 'c')
            {
               accountType = AccountTypes.Checking;
            }
            else if (account == 's')
            {
                accountType = AccountTypes.Savings;
            }
        }

        private string ReadTransactionType()
        {
            string transactionType;

            Console.WriteLine("Would you like to deposit or withdraw into your account? ( d / w )");
            Console.WriteLine("");
            transactionType = Console.ReadLine();

            if (transactionType == "d")
            {

            }
            else if (transactionType == "w")
            {

            }
            else
            {
                Console.WriteLine("Please type a 'd' to deposit into your account, or a 'w' to withdraw from your account.");
                ReadTransactionType();
            }
        }

        private void WelcomeText()
        {
            Console.WriteLine("             *****************************************             ");
            Console.WriteLine("                    Welcome to your Private Bank                   ");
            Console.WriteLine("             *****************************************             ");
            Console.WriteLine("");
        }

    }
}
