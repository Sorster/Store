using System;
using System.Collections;
using static Inputs.NumbersInput;
using static Inputs.StringInput;

namespace Online_store
{
    public class StoreManager : Store
    {
        internal StoreManager(string name, int price, int count)
        {
            counter++;
            ID = counter;
            Name = name;
            Price = price;
            Count = count;
            Cost = Price * Count;
        }

        internal StoreManager()
        {
            counter++;
            ID = counter;
        }

        public static StoreManager operator +(StoreManager product1, StoreManager product2)
        {
            return new StoreManager { Count = product1.Count + product2.Count };
        }

        internal void ShowItem()
        {
            Console.WriteLine($"ID: {ID}");
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Count: {Count}");
            Console.WriteLine($"Price: {Price}$ per item");
            Console.WriteLine($"Total cost: {CalculateCost()}$");
        }

        internal void InputItem()
        {
            Console.Write($"Name: ");
            Name = InputStringWithLettersOnly("Name");
            Console.Write($"Count: ");
            Count = Integer("Count");
            Console.Write($"Price ($ per item): ");
            Price = Integer("Price");
        }

        internal void Assigne_ID(int deleteItemIndex)
        {
            counter = deleteItemIndex;
            ID = counter;
        }

        internal void Assigne_ID()
        {
            counter++;
            ID = counter;           
        }

        internal void Drop_ID()
        {
            counter = 0;
        }

        internal int CalculateCost()
        {
            Cost = Price * Count;
            return Cost; 
        }

        internal int ReturnCount()
        {
            return Count;
        }
    }
}