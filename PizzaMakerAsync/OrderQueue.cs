using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaMakerAsync
{
    internal class OrderQueue
    {
        //public List<Pizza> Orders;
        public List<Order> Orders;
        public object lockObj = new object();

        public OrderQueue()
        {
            //Orders = new List<Pizza>();
            Orders = new List<Order>();
        }

        public List<Order> GetOrders()
        {
            lock (lockObj)
            {
                return Orders;
            }
        }

        public void Add(Order order)
        {
            lock (lockObj)
            {
                Orders.Add(order);
            }
        }

        public void Remove(Order order)
        {
            lock (lockObj)
            {
                Orders.Remove(order);
            }
        }
    }
}
