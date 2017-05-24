using System;

namespace Assignment3
{
    /// <summary>
    /// Represents the Teller user interface
    /// </summary>
    public class TellerUI
    {
        BankAccount account = new BankAccount();

        /// <summary>
        /// Starts the Teller user interface
        /// </summary>
        public void Start()
        {
            WelcomeText();
            AccountTypes accountType = ReadAccountType();

            // Set account to user entered type (doesn't affect functionality)
            account.SetAccountType(accountType);

            // Loop through transactions 
            decimal amount;
            bool repeat;
            do
            {
                // Get transaction type
                TransactionTypes transactionType = ReadTransactionType();

                // Get transaction value from user, value must be positive
                // Convert value to positive or negative depending on transaction type
                amount = ReadTransactionAmount(transactionType);

                // Add transaction to account
                // Prevent withdrawing more than the account currently has as a balance
                if (transactionType == TransactionTypes.Withdrawal && (account.GetBalance() + amount) < 0)
                {
                    Console.WriteLine("Inadequate funds. Transaction canceled.");
                }
                else
                {
                    if (!account.NewTransaction(amount))
                    {
                        Console.WriteLine("No more transactions available.  Transaction canceled.");
                    }
                }

                Console.WriteLine(account.ToString());

                // End Loop (ask user if they want to continue)
                repeat = ReadNewTransaction();
            }
            while (repeat);
        }

        /// <summary>
        /// Gets account type from the user
        /// </summary>
        /// <returns></returns>
        public AccountTypes ReadAccountType()
        {
            char account;
            AccountTypes accountType;

            account = Input.ReadCharConsole("Would you like to access your Checking or Savings account? ( c / s )", 'c', 's');
            Console.WriteLine("");

            if (account == 'c')
            {
               accountType = AccountTypes.Checking;
            }
            else
            {
                accountType = AccountTypes.Savings;
            }

            return accountType;
        }

        /// <summary>
        /// Gets transaction type from the user
        /// </summary>
        /// <returns></returns>
        public TransactionTypes ReadTransactionType()
        {
            char transaction;
            TransactionTypes transactionType;

            transaction = Input.ReadCharConsole("Would you like to deposit or withdraw into your account? ( d / w )", 'd', 'w');
            Console.WriteLine("");

            if (transaction == 'd')
            {
                transactionType = TransactionTypes.Deposit;
            }
            else
            {
                transactionType = TransactionTypes.Withdrawal;
            }

            return transactionType;
        }

        /// <summary>
        /// Gets transaction amount from the user
        /// </summary>
        /// <param name="transactionType"></param>
        /// <returns></returns>
        public decimal ReadTransactionAmount(TransactionTypes transactionType)
        {
            string action;
            decimal multiplier;
            if (transactionType == TransactionTypes.Deposit)
            {
                action = "deposit";
                multiplier = 1;
            }
            else
            {
                // Make amount negative to withdraw from total balance.
                action = "withdraw";
                multiplier = -1;
            }

            // Loop to ensure positive value was entered.
            decimal amount;
            bool repeat = true;
            do
            {
                amount = Input.ReadDecimalConsole("How much would you like to " + action + "? ");

                if (amount <= 0)
                {
                    Console.WriteLine("Amount must be positive.");
                }
                else
                {
                    repeat = false;
                }
            }
            while (repeat);

            return amount * multiplier;
        }

        /// <summary>
        /// Asks the user if they would like to make another transaction.
        /// </summary>
        /// <returns></returns>
        public bool ReadNewTransaction()
        {
            char continueTransaction;

            continueTransaction = Input.ReadCharConsole("Continue with transactions? ( y / n )?", 'y', 'n');

            if (continueTransaction == 'y')
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Initial welcome text.
        /// </summary>
        public void WelcomeText()
        {
            Console.WriteLine("             *****************************************             ");
            Console.WriteLine("                    Welcome to your Private Bank                   ");
            Console.WriteLine("             *****************************************             ");
            Console.WriteLine("");
        }

    }
}
