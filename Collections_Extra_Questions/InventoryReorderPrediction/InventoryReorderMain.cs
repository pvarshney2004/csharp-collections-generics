using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Collections_Extra_Questions.InventoryReorderPrediction
{
    public class InventoryReorderMain
    {
        public static void Execute()
        {
            Dictionary<string, int> stock = new Dictionary<string, int>
            {
            { "Pen", 20 }
            };

            InventoryReorder mng = new InventoryReorder(stock);

            // Last 7 days sales
            mng.AddSale("Pen", 2);
            mng.AddSale("Pen", 3);
            mng.AddSale("Pen", 0);
            mng.AddSale("Pen", 4);
            mng.AddSale("Pen", 5);
            mng.AddSale("Pen", 6);
            mng.AddSale("Pen", 5);

            Console.WriteLine("Average Sales: " + mng.MovingAverage("Pen"));

            Console.WriteLine("Reorder Required: " + mng.ShouldReorder("Pen"));

            DateTime? date = mng.PredictStockOut("Pen");
            Console.WriteLine("Predicted Stock-out Date: " + (date.HasValue ? date.Value.ToShortDateString() : "N/A"));
        }
    }
}