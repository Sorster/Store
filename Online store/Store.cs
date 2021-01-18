using System;

namespace Online_store
{
    public class Store
    {
        protected static int counter = 0;
        protected int ID { get; set; }
        protected string Name { get; set; }
        protected int Price { get; set; }
        protected int Count { get; set; }
        protected int Cost { get; set; }
    }
}
