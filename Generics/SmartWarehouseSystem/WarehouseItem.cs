using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Generics.SmartWarehouseSystem
{
    // abstract base class
    public abstract class WarehouseItem
    {
        public string? Name { get; set; }
        public int Quantity { get; set; }
        public abstract void Display(); // abstract method
    }
}