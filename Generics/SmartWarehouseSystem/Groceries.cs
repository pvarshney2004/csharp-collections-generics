using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Generics.SmartWarehouseSystem
{
    // subclass implementing parent class abstract members
    public class Groceries : WarehouseItem
    {
        public override void Display()
        {
            Console.WriteLine($"Groceries: {Name}, Quantity: {Quantity}");

        }
    }
}