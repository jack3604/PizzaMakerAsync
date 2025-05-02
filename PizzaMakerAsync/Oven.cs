using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaMakerAsync
{
    internal class Oven
    {
        public List<Order> Belt;
        public double BeltSpeed;
        public CancellationTokenSource OvenCancellationTokenSource;
        private object lockObj = new object();

        public Oven(double beltSpeed)
        {
            Belt = new List<Order>();
            BeltSpeed = beltSpeed;
            OvenCancellationTokenSource = new CancellationTokenSource();
        }

        public void Start()
        {
            if (OvenCancellationTokenSource.Token.IsCancellationRequested)
            {
                OvenCancellationTokenSource = new CancellationTokenSource();
            }

            _ = AdvanceBeltAsync(OvenCancellationTokenSource.Token);
        }

        public void Stop()
        {
            OvenCancellationTokenSource.Cancel();
            lock (lockObj)
            {
                Belt = new List<Order>();
            }
        }

        public async Task AdvanceBeltAsync(CancellationToken cancellationToken)
        {
            while (!cancellationToken.IsCancellationRequested)
            {
                AdvanceBelt();

                await Task.Delay(500, cancellationToken);
            }
        }

        private void AdvanceBelt()
        {
            lock (lockObj)
            {
                foreach (Order o in Belt)
                {
                    o.GetPizza().AdvanceBakeProgress(BeltSpeed);
                }
            }
        }

        public void Add(Order o)
        {
            lock (lockObj)
            {
                Belt.Add(o);
            }
        }

        public void Remove(Order o)
        {
            lock (lockObj)
            {
                Belt.Remove(o);
            }
        }

        public List<Order> GetOrders() 
        {
            lock (lockObj)
            {
                return Belt;
            }
        }

        public void AddNext(Order o)
        {
            lock (lockObj)
            {
                List<Order> newBelt = new List<Order>();
                newBelt.Add(o);
                for (int i = 0; i < Belt.Count; i++)
                {
                    newBelt.Add(Belt[i]);
                }
                Belt = newBelt;
            }
        }
    }
}
