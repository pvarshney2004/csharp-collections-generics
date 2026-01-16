using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Generics.SmartWarehouseSystem
{
    // subclass implementing parent class abstract memberss
    public class Furniture : WarehouseItem
    {
        public override void Display()
        {
            Console.WriteLine($"Furniture: {Name}, Quantity: {Quantity}");
        }
    }
}