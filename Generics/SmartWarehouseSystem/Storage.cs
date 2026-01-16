using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Generics.SmartWarehouseSystem
{
    // generic class
    public class Storage<T> where T : WarehouseItem
    {
        private List<T> items = new List<T>(); // private list to store items
        public void AddItem(T item)
        {
            items.Add(item);
        }
        public List<T> GetItems()
        {
            return items;
        }
        public void Display()
        {
            foreach (T item in items)
            {
                item.Display(); // demonstrating polymorphism
            }
        }
    }
}