using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Generics.SmartWarehouseSystem
{
    /*
    1. Smart Warehouse Management System
o Concepts: Generic Classes, Constraints, Variance
o Problem Statement: Develop a warehouse system that manages
different types of items (Electronics, Groceries, Furniture).
o Hints:
▪ Create an abstract class WarehouseItem that all items
extend (Electronics, Groceries, Furniture).
▪ Implement a generic class Storage<T> where T :
WarehouseItem to store items safely.
▪ Implement a method to display all items using List<T>.
    */
    public class SmartWarehouseMain
    {
        public static void Execute()
        {
            Storage<Electronics> electronicsStorage = new Storage<Electronics>();
            electronicsStorage.AddItem(new Electronics { Name = "Laptop", Quantity = 10 });
            electronicsStorage.AddItem(new Electronics { Name = "Mobile", Quantity = 20 });

            Storage<Groceries> groceriesStorage = new Storage<Groceries>();
            groceriesStorage.AddItem(new Groceries { Name = "Rice", Quantity = 50 });
            groceriesStorage.AddItem(new Groceries{Name = "Wheat", Quantity = 30});

            Storage<Furniture> furnitureStorage = new Storage<Furniture>();
            furnitureStorage.AddItem(new Furniture { Name = "Chair", Quantity = 15 });
            furnitureStorage.AddItem(new Furniture { Name = "Table", Quantity = 21 });

            Console.WriteLine("Electronics Storage:");
            electronicsStorage.Display();

            Console.WriteLine("Groceries Storage:");
            groceriesStorage.Display();

            Console.WriteLine("Furniture Storage:");
            furnitureStorage.Display();
        }
    }
}