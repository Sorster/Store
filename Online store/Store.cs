using System;

namespace Online_store
{
    public class Store : StoreManager
    {
        internal int _ID { get; set; }
        internal string _name { get; set; }
        internal int _price { get; set; }
        internal int _count { get; set; }

        internal Store() { }

        internal Store(int ID)
        {
            _ID = ID;
        }

        internal Store(int ID, string name, int price, int count)
        {
            _ID = ID;
            _name = name;
            _price = price;
            _count = count;
        }
    }
}
