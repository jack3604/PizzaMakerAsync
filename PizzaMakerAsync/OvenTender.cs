using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;

namespace PizzaMakerAsync
{
    internal class OvenTender : Employee
    {
        Oven PizzaOven;
        Rack PizzaRack;
        Order? CurrentOrder;
        CancellationTokenSource OvenTenderCancellationTokenSource;

        public OvenTender(string name, Oven oven, Rack rack) : base(name, new CancellationTokenSource())
        {
            PizzaOven = oven;
            PizzaRack = rack;
            CurrentOrder = null;
            OvenTenderCancellationTokenSource = base.GetCancellationTokenSource();
        }

        public override void Start()
        {
            _ = WaitForPizza(OvenTenderCancellationTokenSource.Token);
        }

        public override void Stop()
        {
            OvenTenderCancellationTokenSource.Cancel();
            if (CurrentOrder != null)
            {
                PizzaOven.AddNext(CurrentOrder);
            }
        }

        public async Task WaitForPizza(CancellationToken cancellationToken)
        {
            while (!cancellationToken.IsCancellationRequested)
            {
                if (IsPizzaReady())
                {
                    await CutNextPizzaAsync(cancellationToken);
                }

                await Task.Delay(100, cancellationToken);
            }
        }

        public bool IsPizzaReady()
        {
            List<Order> Belt = PizzaOven.GetOrders();

            foreach (Order o in Belt)
            {
                if (o.GetPizza().IsBaked())
                {
                    return true;
                }
            }

            return false;
        }

        public Order? GetNextOrder()
        {
            List<Order> Belt = PizzaOven.GetOrders();

            foreach (Order o in Belt)
            {
                if (o.GetPizza().IsBaked())
                {
                    return o;
                }
            }

            return null;
        }

        public async Task CutNextPizzaAsync(CancellationToken cancellationToken)
        {
            CurrentOrder = GetNextOrder();

            if (CurrentOrder != null)
            {
                SetCurrentTask("Cutting pizza");
                PizzaOven.Remove(CurrentOrder);

                await Task.Delay(2000);
                if (!cancellationToken.IsCancellationRequested)
                {
                    PizzaRack.Add(CurrentOrder);
                }
            }
            
            SetCurrentTask("Waiting");
            CurrentOrder = null;
        }
    }
}
