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
        CancellationTokenSource PizzaMakerCancellationTokenSource;


        public PizzaMaker(string name, OrderQueue orders, Oven pizzaOven) : base(name, new CancellationTokenSource())
        {
            Orders = orders;
            PizzaOven = pizzaOven;
            CurrentOrder = null;
            PizzaMakerCancellationTokenSource = base.GetCancellationTokenSource();
        }

        public override void Start()
        {
            _ = WaitForOrder(PizzaMakerCancellationTokenSource.Token);
        }

        public override void Stop()
        {
            PizzaMakerCancellationTokenSource.Cancel();
            if (CurrentOrder != null)
            {
                Orders.Add(CurrentOrder);
            }
        }

        public async Task WaitForOrder(CancellationToken cancellationToken)
        {
            while (!cancellationToken.IsCancellationRequested)
            {
                if (Orders.GetOrders().Count > 0)
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

            await StretchDoughAsync();
            await AddSauceAndCheeseAsync();
            await AddToppingsAsync();

            if (!cancellationToken.IsCancellationRequested)
            {
                PizzaOven.Add(CurrentOrder);
            }

            SetCurrentTask("Waiting");
            CurrentOrder = null;
        }

        public async Task StretchDoughAsync()
        {
            SetCurrentTask("Stretching dough");
            await Task.Delay(2000);
        }

        public async Task AddSauceAndCheeseAsync()
        {
            SetCurrentTask("Adding sauce");
            await Task.Delay(1000);
        }

        public async Task AddToppingsAsync()
        {
            if (CurrentOrder != null)
            {
                SetCurrentTask("Adding " + CurrentOrder.GetPizza().GetDescription());
                await Task.Delay(3000);
            }
        }
    }
}
