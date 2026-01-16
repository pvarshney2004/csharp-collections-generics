using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Collections_Extra_Questions.BankTransactionFraudDetection
{
    public class FraudDetectionMain
    {
        public static void Execute()
        {
            Dictionary<long, double> balances = new Dictionary<long, double>
            {
                {1001, 10000}
            };
            FraudDetection detector = new FraudDetection(balances);
            DateTime now = DateTime.Now;
            detector.ProcessTransaction(1001,
                new Transaction(now.AddMinutes(-9), 1000, true));

            detector.ProcessTransaction(1001,
                new Transaction(now.AddMinutes(-8), 1200, true));

            detector.ProcessTransaction(1001,
                new Transaction(now.AddMinutes(-7), 900, true));

            detector.ProcessTransaction(1001,
                new Transaction(now.AddMinutes(-6), 500, true));

            detector.GenerateReport();
        }
    }
}
