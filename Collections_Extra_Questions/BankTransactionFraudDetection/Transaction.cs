using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Collections_Extra_Questions.BankTransactionFraudDetection
{
    // transaction class
    public class Transaction
    {
        public DateTime Time { get; set; }
        public double Amount { get; set; }
        public bool IsWithdrawal { get; set; }

        public Transaction(DateTime time, double amount, bool isWithdrawal)
        {
            Time = time;
            Amount = amount;
            IsWithdrawal = isWithdrawal;
        }
    }
}