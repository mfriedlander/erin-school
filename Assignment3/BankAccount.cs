using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    class BankAccount
    {
        private const int maxNumOfTransactions = 100;
        private decimal balance;
        private AccountTypes accountType;
        private decimal[] transactions = new decimal[maxNumOfTransactions];
        public void SetAccountType(AccountTypes currentAccountType)
        {
            accountType = currentAccountType;
        }

        public bool NewTransaction(decimal amount)
        {
            bool vacantSpot = true;
            int firstVacantPosition = FindVacantPosition();
            if (firstVacantPosition != -1)
            {
                transactions[firstVacantPosition] = amount;
                balance += amount;
            }
            else
            {
                vacantSpot = false;
                return vacantSpot;
            }
        }

        private int FindVacantPosition()
        {

        }

        private decimal GetBalance()
        {

        }

        private decimal GetSumOfAllDeposits()
        {

        }

        private decimal GetSumOfAllWithdrawals()
        {

        }
    }
}
