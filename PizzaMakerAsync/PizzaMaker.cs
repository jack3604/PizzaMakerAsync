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
        public event EventHandler<PizzaMakerEventArgs>? OrderStretched;
        public event EventHandler<PizzaMakerEventArgs>? OrderSauced;
        public event EventHandler<PizzaMakerEventArgs>? OrderCheesed;
        public event EventHandler<PizzaMakerEventArgs>? OrderTopped;


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

        public void CancelOrder(string reason)
        {
            if (CurrentOrder != null)
            {
                CurrentOrder = null;
            }

            SetCurrentTask(reason);
        }

        public Order GetCurrentOrder()
        {
            return CurrentOrder;
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

            if (CurrentOrder != null)
            {
                if (!cancellationToken.IsCancellationRequested)
                {
                    PizzaOven.Add(CurrentOrder);
                }
            }

            CurrentOrder = null;
        }

        public async Task StretchDoughAsync(CancellationToken cancellationToken)
        {
            if (!cancellationToken.IsCancellationRequested)
            {
                if (CurrentOrder != null)
                {
                    SetCurrentTask("Stretching dough");
                    OrderStretched?.Invoke(this, new PizzaMakerEventArgs(this));
                    await Task.Delay(2000);
                }
            }
        }

        public async Task AddSauceAndCheeseAsync(CancellationToken cancellationToken)
        {
            if (!cancellationToken.IsCancellationRequested)
            {
                if (CurrentOrder != null)
                {
                    SetCurrentTask("Adding sauce");
                    OrderSauced?.Invoke(this, new PizzaMakerEventArgs(this));
                    OrderCheesed?.Invoke(this, new PizzaMakerEventArgs(this));
                    await Task.Delay(1000);
                }
            }
        }

        public async Task AddToppingsAsync(CancellationToken cancellationToken)
        {
            if (!cancellationToken.IsCancellationRequested)
            {
                if (CurrentOrder != null)
                {
                    SetCurrentTask("Adding " + CurrentOrder.GetPizza().GetDescription());
                    OrderTopped?.Invoke(this, new PizzaMakerEventArgs(this));
                    await Task.Delay(3000);
                }
            }
        }
    }
}
