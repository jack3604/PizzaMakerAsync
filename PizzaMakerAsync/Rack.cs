using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaMakerAsync
{
    internal class Rack
    {
        public List<Order> PizzaRack;
        public event Action<Order>? OrderAdded;

        public Rack()
        {
            PizzaRack = new List<Order>();
        }


        public void Add(Order order)
        {
            PizzaRack.Add(order);

            OrderAdded?.Invoke(order);
        }

        public void Remove(Order order) 
        {
            PizzaRack.Remove(order);
        }

        public void Clear() 
        {
            PizzaRack.Clear();
        }

        public List<Order> GetOrders()
        {
            return PizzaRack;
        }
    }
}
