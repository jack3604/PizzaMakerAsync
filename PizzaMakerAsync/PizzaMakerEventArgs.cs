using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaMakerAsync
{
    internal class PizzaMakerEventArgs : EventArgs
    {
        public PizzaMaker PizzaMaker { get; }

        public PizzaMakerEventArgs(PizzaMaker pizzaMaker)
        {
            PizzaMaker = pizzaMaker;
        }
    }
}
