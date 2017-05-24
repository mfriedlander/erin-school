using System;

namespace Assignment3
{
    /// <summary>
    /// Represents a bank account
    /// </summary>
    public class BankAccount
    {
        private const int maxNumOfTransactions = 100;
        private decimal balance;
        private AccountTypes accountType;
        private decimal[] transactions = new decimal[maxNumOfTransactions];

        /// <summary>
        /// Sets the account type
        /// </summary>
        /// <param name="currentAccountType">Account type</param>
        public void SetAccountType(AccountTypes currentAccountType)
        {
            accountType = currentAccountType;
        }

        /// <summary>
        /// Adds a new transaction to this account.
        /// </summary>
        /// <param name="amount">Amount to add to the account (negative or positive)</param>
        /// <returns>Success or failure of the transaction.</returns>
        public bool NewTransaction(decimal amount)
        {
            bool success = true;
            int firstVacantPosition = FindVacantPosition();

            if (firstVacantPosition != -1)
            {
                transactions[firstVacantPosition] = amount;
                balance += amount;
            }
            else
            {
                // Transaction list is full, don't commit transaction
                success = false;
            }

            return success;
        }

        /// <summary>
        /// Returns the account balance
        /// </summary>
        /// <returns>Account balance.</returns>
        public decimal GetBalance()
        {
            // Return balance - no need to calculate because it is tracked during every transaction
            return balance;
        }

        /// <summary>
        /// Returns total of all deposits made
        /// </summary>
        /// <returns>Total of deposits</returns>
        public decimal GetSumOfAllDeposits()
        {
            decimal total = 0;

            // Iterate over all transactions, return all that are positive.
            for(int i = 0; i < maxNumOfTransactions; i++)
            {
                if (transactions[i] > 0)
                {
                    total += transactions[i];
                }
                else if (transactions[i] == 0)
                {
                    // We can exit upon finding a zero value
                    break;
                }
            }

            return total;
        }

        /// <summary>
        /// Returns total of all withdrawals made
        /// </summary>
        /// <returns>Total of withdrawals.</returns>
        public decimal GetSumOfAllWithdrawals()
        {
            decimal total = 0;

            // Iterate over all transactions, return all that are negative.
            for (int i = 0; i < maxNumOfTransactions; i++)
            {
                if (transactions[i] < 0)
                {
                    total += transactions[i];
                }
                else if (transactions[i] == 0)
                {
                    // We can exit upon finding a zero value
                    break;
                }
            }

            return total * -1;
        }

        /// <summary>
        /// Returns formatted string with account data
        /// </summary>
        /// <returns>Formatted string</returns>
        public override string ToString()
        {
            string type = Enum.GetName(typeof(AccountTypes), accountType);
            string strOut = String.Format("Account type: {0}\nBalance: {1, -8:C}\nTotal Deposits: {2, -8:C}\nTotal Withdrawals: {3, -8:C}", accountType, balance, GetSumOfAllDeposits(), GetSumOfAllWithdrawals());

            return strOut;
        }

        /// <summary>
        /// Finds first empty position in the transaction array
        /// </summary>
        /// <returns>Index of first empty position or -1 if none is available.</returns>
        private int FindVacantPosition()
        {
            // Iterate over transaction array, return index of first zero value found
            // If array is full, return -1
            for (int i = 0; i < maxNumOfTransactions; i++)
            {
                if (transactions[i] == 0)
                {
                    return i;
                }
            }

            return -1;
        }
    }
}
