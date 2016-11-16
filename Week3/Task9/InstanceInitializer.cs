using System;
using System.Collections.Generic;

namespace Task9
{
    static class InstanceInitializer
    {
        public static Goods goods1;
        public static Goods goods2;
        public static GoodsStore goodsStore1;
        public static GoodsStore goodsStore2;
        public static Store store = null;
        public static GoodsOrder goodsOrder1;
        public static GoodsOrder goodsOrder2;
        public static Customer customer1;
        public static Customer customer2;
        
        public static void Initialize()
        {
            goods1 = new Smartphone("IPhone7", 700, "IOS", 5.0f, "Intel v5.001", 4);
            goods2 = new Smartphone("Samsung Galaxy S7", 600, "Android", 5.0f, "Intel v4.87", 4);
            goodsStore1 = new GoodsStore(goods1, 10);
            goodsStore2 = new GoodsStore(goods2, 12);
            
            store = new Store(new List<GoodsStore>()
                    {
                        goodsStore1,
                        goodsStore2
                    });
            goodsOrder1 = new GoodsOrder(goods1, 1);
            goodsOrder2 = new GoodsOrder(goods2, 2);

            customer1 = new Customer("Tom Flatcher", 800);
            customer2 = new Customer("Nick Johansen", 1000);
        }
    }
}
