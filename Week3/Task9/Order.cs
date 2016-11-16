using System;
using System.Collections.Generic;

namespace Task9
{
    class Order
    {
        public static uint CurrentId = 1;
        public uint OrderId { get; set; }
        public DateTime Date { get; set; }
        public Customer Customer { get; set; }
        public List<GoodsOrder> Goods { get; set; }
        public double TotalPrice { get; set; }

        public event EventHandler<OrderEventArgs> CreateOrderEvent;
        public event EventHandler<OrderEventArgs> CompleteOrderEvent;

        public static uint GetId()
        {
            return CurrentId++;
        }

        public Order(Customer customer, List<GoodsOrder> goods)
        {
            Date = DateTime.Now;
            Customer = customer;
            Goods = goods;
            OrderId = GetId();
            // Calculate Total price of order
            foreach (var g in Goods)
            {
                TotalPrice += g.Goods.Price*g.Count;
            }
            // Subscription of method ConfirmOrder in Customer to event CreateOrderEvent in Order for sending informatiopn about creating new order
            CreateOrderEvent += customer.ConfirmOrder;
            // Subscription to event ConfirmOrderEvent in Customer when he confirm created order
            customer.ConfirmOrderEvent += CompleteOrder;
            // Subscription of metho GoodsRecalculate in Store to event CompleteOrderEvent for starting of recalculation GoodgOrder in Store
            CompleteOrderEvent += Store.GoodsRecalculate;
            OnCreateOrder(new OrderEventArgs(this, "created new order"));
        }

        protected void OnCreateOrder(OrderEventArgs e)
        {
            EventHandler<OrderEventArgs> handler = CreateOrderEvent;
            if (handler != null)
            {
                e.Message += String.Format(" - Date:{0}, Customer: {1}, Goods: {2}. Total price: {3}$", Date, Customer, Goods.Print(), TotalPrice);
                handler(this, e);
            }
        }

        // Method for order completion
        public void CompleteOrder(object sender, OrderEventArgs e)
        {
            Messager.SendMessage(string.Format("Order with id {0} {1}!", e.Order.OrderId, e.Message));
            OnCompleteOrder(new OrderEventArgs(this, "completed order"));
        }

        protected void OnCompleteOrder(OrderEventArgs e)
        {
            if (CompleteOrderEvent != null)
            {
                CompleteOrderEvent(this, e);
            }
        }
    }

    class OrderEventArgs : EventArgs
    {
        public Order Order { get; set; }
        public string Message { get; set; }

        public OrderEventArgs(Order order, string message)
        {
            Order = order;
            Message = message;
        }
    }
}
