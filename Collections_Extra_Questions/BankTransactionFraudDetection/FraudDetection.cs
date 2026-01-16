using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Collections_Extra_Questions.BankTransactionFraudDetection
{
    /*
    Bank Transaction Fraud Detector
Problem Statement
Implement fraud detection logic in a banking system.
Use:
● Dictionary<long, List<Transaction>>
● Queue<Transaction>
Tasks
1. Flag account if:
○ More than 3 withdrawals in 10 minutes
○ Withdrawal > 80% of balance
2. Generate suspicious transaction report.
Edge Cases
● Transactions at exact 10-minute boundary
● Balance changing after each transaction
● Same timestamp transactions
● Zero balance withdrawal
● Queue not cleared properly
    */
    public class FraudDetection
    {
        // private Dictionary and List to store transactions data
        private Dictionary<long, List<Transaction>> accountTransactions;
        private Dictionary<long, double> accountBalances;
        private List<long> flaggedAccounts;

        public FraudDetection(Dictionary<long, double> balances)
        {
            accountBalances = balances;
            accountTransactions = new Dictionary<long, List<Transaction>>();
            flaggedAccounts = new List<long>();
        }

        // method to process the transaction
        public void ProcessTransaction(long accountNo, Transaction txn)
        {
            if (!accountTransactions.ContainsKey(accountNo))
                accountTransactions[accountNo] = new List<Transaction>();

            accountTransactions[accountNo].Add(txn);

            if (txn.IsWithdrawal)
            {
                // flagged account if Withdrawal > 80% of balance
                if (accountBalances[accountNo] == 0 ||
                    txn.Amount > 0.8 * accountBalances[accountNo])
                {
                    FlagAccount(accountNo);
                }

                // checking More than 3 withdrawals in 10 minutes
                CheckRapidWithdrawals(accountNo, txn);
            }
            UpdateBalance(accountNo, txn); // updating balance
        }

        // Sliding window using Queue
        private void CheckRapidWithdrawals(long accountNo, Transaction txn)
        {
            Queue<Transaction> q = new Queue<Transaction>();

            foreach (var t in accountTransactions[accountNo])
            {
                if (t.IsWithdrawal)
                    q.Enqueue(t);
            }

            // Clear old transactions (≤ 10 minutes allowed)
            while (q.Count > 0 &&
                   (txn.Time - q.Peek().Time).TotalMinutes > 10)
            {
                q.Dequeue();
            }

            if (q.Count > 3)
            {
                FlagAccount(accountNo);
            }
        }

        private void UpdateBalance(long accountNo, Transaction tx)
        {
            if (tx.IsWithdrawal)
                accountBalances[accountNo] -= tx.Amount;
            else
                accountBalances[accountNo] += tx.Amount;
        }

        private void FlagAccount(long accountNo)
        {
            if (!flaggedAccounts.Contains(accountNo))
                flaggedAccounts.Add(accountNo);
        }

        // Generating Suspicious Transaction Report
        public void GenerateReport()
        {
            Console.WriteLine("Suspicious Accounts Report\n");

            foreach (var acc in flaggedAccounts)
            {
                Console.WriteLine($"Account No: {acc}");
            }
        }
    }
}