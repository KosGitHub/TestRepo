using System;
using System.Collections.Generic;

namespace Task9
{
    class Program
    {
        static void Main(string[] args)
        {
            Messager.SendMessageEvent += ShowMessageToConsole;
            InstanceInitializer.Initialize();
            Order order1 = new Order(InstanceInitializer.customer1, new List<GoodsOrder>() { InstanceInitializer.goodsOrder1 });
            Console.WriteLine(new string('-', 70));
            Order order2 = new Order(InstanceInitializer.customer2, new List<GoodsOrder>() { InstanceInitializer.goodsOrder1, InstanceInitializer.goodsOrder2 });

            Console.ReadLine();
        }

        public static void ShowMessageToConsole(string message)
        {
            Console.WriteLine(message);
        }
    }
}
