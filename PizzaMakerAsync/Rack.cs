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

        public Rack()
        {
            PizzaRack = new List<Order>();
        }

        public void Add(Order o)
        {
            PizzaRack.Add(o);
        }

        public void Remove(Order o) 
        {
            PizzaRack.Remove(o);
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
