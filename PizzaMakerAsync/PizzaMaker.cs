using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaMakerAsync
{
    internal class PizzaMaker : Employee
    {
        OrderQueue Orders;
        public Oven PizzaOven;
        Order? CurrentOrder;


        public PizzaMaker(string name, OrderQueue orders, Oven pizzaOven) : base(name)
        {
            Orders = orders;
            PizzaOven = pizzaOven;
            CurrentOrder = null;
        }

        public override void Start()
        {
            if (base.GetCancellationTokenSource().Token.IsCancellationRequested)
            {
                base.RefreshCancellationTokenSource();
            }

            _ = WaitForOrderAsync(base.GetCancellationTokenSource().Token);
        }

        public override void Stop()
        {
            base.GetCancellationTokenSource().Cancel();
            if (CurrentOrder != null)
            {
                Orders.Add(CurrentOrder);
            }
        }

        public async Task WaitForOrderAsync(CancellationToken cancellationToken)
        {
            while (!cancellationToken.IsCancellationRequested)
            {
                SetCurrentTask("Waiting");

                if (Orders.GetOrderCount() > 0)
                {
                    await MakeNextOrderAsync(cancellationToken);
                }

                await Task.Delay(100, cancellationToken);
            }
        }

        public async Task MakeNextOrderAsync(CancellationToken cancellationToken)
        {
            CurrentOrder = Orders.GetOrders()[0];

            Orders.Remove(CurrentOrder);

            await StretchDoughAsync(cancellationToken);
            await AddSauceAndCheeseAsync(cancellationToken);
            await AddToppingsAsync(cancellationToken);

            if (!cancellationToken.IsCancellationRequested)
            {
                PizzaOven.Add(CurrentOrder);
            }

            CurrentOrder = null;
        }

        public async Task StretchDoughAsync(CancellationToken cancellationToken)
        {
            if (!cancellationToken.IsCancellationRequested)
            {
                SetCurrentTask("Stretching dough");
                await Task.Delay(2000);
            }
        }

        public async Task AddSauceAndCheeseAsync(CancellationToken cancellationToken)
        {
            if (!cancellationToken.IsCancellationRequested)
            {
                SetCurrentTask("Adding sauce");
                await Task.Delay(1000);
            }
        }

        public async Task AddToppingsAsync(CancellationToken cancellationToken)
        {
            if (!cancellationToken.IsCancellationRequested)
            {
                if (CurrentOrder != null)
                {
                    SetCurrentTask("Adding " + CurrentOrder.GetPizza().GetDescription());
                    await Task.Delay(3000);
                }
            }
        }
    }
}
