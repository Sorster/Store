using System;
using Inputs;

namespace Online_store
{
    public class StoreManager
    {
        internal void ShowItem(Store item)
        {
            Console.WriteLine($"ID: {item._ID}");
            Console.WriteLine($"Name: {item._name}");
            Console.WriteLine($"Count: {item._count}");
            Console.WriteLine($"Price: {item._price}$ per item");
            Console.WriteLine($"Total cost: {item.ItemCost(item)}$");
        }

        internal void InputItem(Store item)
        {
            Console.Write($"Name: ");
            item._name = Console.ReadLine();
            Console.Write($"Count: ");
            item._count = Input.Integer();
            Console.Write($"Price ($ per item): ");
            item._price = Input.Integer();
        }

        internal int ItemCost(Store item)
        {
            return item._price * item._count; 
        }
    }
}