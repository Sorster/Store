using System;
using Inputs;

namespace Online_store
{
    public class StoreManager : Store
    {
        internal StoreManager() { }

        internal StoreManager(int ID, string name, int price, int count)
        {
            _ID = ID;
            _name = name;
            _price = price;
            _count = count;
        }

        internal StoreManager(int ID)
        {
            _ID = ID;
        }

        internal void ShowItem()
        {
            Console.WriteLine($"ID: {_ID}");
            Console.WriteLine($"Name: {_name}");
            Console.WriteLine($"Count: {_count}");
            Console.WriteLine($"Price: {_price}$ per item");
            Console.WriteLine($"Total cost: {CalculateCost()}$");
        }

        internal void InputItem()
        {
            Console.Write($"Name: ");
            _name = Console.ReadLine();
            Console.Write($"Count: ");
            _count = Input.Integer();
            Console.Write($"Price ($ per item): ");
            _price = Input.Integer();
        }

        internal int CalculateCost()
        {
            return _price * _count; 
        }
    }
}