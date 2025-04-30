using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaMakerAsync
{
    internal class Order
    {
        public int Id;
        public Pizza _Pizza;

        public Order(int id, Pizza pizza)
        {
            Id = id;
            _Pizza = pizza;
        }

        public int GetId()
        {
            return Id;
        }

        public Pizza GetPizza() 
        {
            return _Pizza; 
        }
    }
}
