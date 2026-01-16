using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Collections_Extra_Questions.InventoryReorderPrediction
{
    public class InventoryReorder
    {
        // private data members to store sales and stock data
        private Dictionary<string, Queue<int>> salesData;
        private Dictionary<string, int> stock;

        public InventoryReorder(Dictionary<string, int> initialStock)
        {
            salesData = new Dictionary<string, Queue<int>>();
            stock = initialStock;
        }

        // method to add daily sale
        public void AddSale(string product, int quantity)
        {
            if (quantity < 0) quantity = 0;

            if (!salesData.ContainsKey(product))
            {
                salesData[product] = new Queue<int>();
            }
            Queue<int> q = salesData[product];
            q.Enqueue(quantity);
            // queue overflow control
            if (q.Count > 7)
            {
                q.Dequeue();
            }
        }

        // method to calculate moving average
        public double MovingAverage(string product)
        {
            if (!salesData.ContainsKey(product) || salesData[product].Count == 0) return 0;
            return salesData[product].Average();
        }

        // method to reorder check
        public bool ShouldReorder(string product)
        {
            if (!stock.ContainsKey(product)) return false;

            double avg = MovingAverage(product);
            return avg > stock[product];
        }

        // method to predict stock-out date
        public DateTime? PredictStockOut(string product)
        {
            if (!stock.ContainsKey(product))
            {
                return null;
            }

            double avg = MovingAverage(product);
            if (avg <= 0) return null; // no sales → no stock-out

            int days = (int)Math.Ceiling(stock[product] / avg);
            return DateTime.Today.AddDays(days);
        }
    }
}