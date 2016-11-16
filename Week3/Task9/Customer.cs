using System;
using System.Collections.Generic;

namespace Task9
{
    class Customer
    {
        public string Name { get; set; }
        public double CashAmount { get; private set; }
        public List<Order> Orders { get; set; }

        public event EventHandler<OrderEventArgs> ConfirmOrderEvent; 

        public Customer(string name, float cashAmount)
        {
            Name = name;
            CashAmount = cashAmount;
            Orders = new List<Order>();
        }

        // Method for confirm registered orders
        public void ConfirmOrder(object sender, OrderEventArgs e)
        {
            Messager.SendMessage(String.Format("In {0} private cabinet was {1}", Name, e.Message));
            if (e.Order.TotalPrice <= CashAmount)
            {
                CashAmount -= e.Order.TotalPrice;
                Orders.Add(e.Order);
                OnConfirmOrderEvent(new OrderEventArgs(e.Order, "was confirmed"));
            }
            else
            {
                Messager.SendMessage(String.Format("{0} does not have sufficient funds to implement order with id {1}!", Name, e.Order.OrderId));
                OnConfirmOrderEvent(new OrderEventArgs(e.Order, "was not confirmed"));
            }
        }

        protected void OnConfirmOrderEvent(OrderEventArgs e)
        {
            if (ConfirmOrderEvent != null)
            {
                ConfirmOrderEvent(this, e);
            }
        }

        public override string ToString()
        {
            return String.Format(Name);
        }
    }
}
