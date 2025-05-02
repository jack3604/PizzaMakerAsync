namespace PizzaMakerAsync
{
    internal class Store
    {
        List<PizzaMaker> StorePizzaMakerList;
        List<OvenTender> StoreOvenTenderList;
        Rack StoreRack;
        Oven StoreOven;
        OrderQueue StoreOrders;
        int StoreOrderCount;
        int StoreDaysOpen;
        bool StoreOpen;
        int StoreMoney;

        public Store()
        {
            StorePizzaMakerList = new List<PizzaMaker>();
            StoreOvenTenderList = new List<OvenTender>();
            StoreRack = new Rack();
            StoreOven = new Oven(0.2);
            StoreOrders = new OrderQueue();
            StoreOrderCount = 0;
            StoreDaysOpen = 0;
            StoreOpen = false;
            StoreMoney = 0;

            StoreRack.OrderAdded += OnOrderAdded;
        }

        private void OnOrderAdded(Order order)
        {
            StoreMoney += 10;
        }

        public List<PizzaMaker> GetPizzaMakers()
        {
            return StorePizzaMakerList;
        }

        public List<OvenTender> GetOvenTenders()
        {
            return StoreOvenTenderList;
        }

        public Rack GetRack()
        {
            return StoreRack;
        }

        public Oven GetOven()
        {
            return StoreOven;
        }

        public OrderQueue GetOrderQueue()
        {
            return StoreOrders;
        }

        public int GetDaysOpen()
        {
            return StoreDaysOpen;
        }

        public bool IsOpen()
        {
            return StoreOpen;
        }

        public int GetMoney()
        {
            return StoreMoney;
        }

        public void OpenStore()
        {
            StoreOpen = true;
            StoreOven.Start();
            StoreOrderCount = 0;

            foreach (PizzaMaker pm in StorePizzaMakerList)
            {
                pm.SetCurrentTask("Waiting");
                pm.Start();
            }

            foreach (OvenTender ot in StoreOvenTenderList)
            {
                ot.SetCurrentTask("Waiting");
                ot.Start();
            }
        }

        public void CloseStore()
        {
            foreach (PizzaMaker pm in StorePizzaMakerList)
            {
                pm.SetCurrentTask("Store closed");
                pm.Stop();
            }

            foreach (OvenTender ot in StoreOvenTenderList)
            {
                ot.SetCurrentTask("Store closed");
                ot.Stop();
            }
            
            StoreOpen = false;
            StoreOrders.Clear();
            StoreOven.Stop();
            StoreRack.Clear();
        }

        public void HirePizzaMaker(string employeeName)
        {
            PizzaMaker pm = new PizzaMaker(employeeName, StoreOrders, StoreOven);
            StorePizzaMakerList.Add(pm);

            if (StoreOpen)
            {
                pm.Start();
            }
            else
            {
                pm.SetCurrentTask("Store closed");
            }
        }

        public void FirePizzaMaker(PizzaMaker pm)
        {
            if (StorePizzaMakerList.Count > 0)
            {
                pm.Stop();
                StorePizzaMakerList.Remove(pm);
            }
        }

        public void FireLastPizzaMaker()
        {
            if (StorePizzaMakerList.Count > 0)
            {
                PizzaMaker pm = StorePizzaMakerList[StorePizzaMakerList.Count - 1];
                pm.Stop();
                StorePizzaMakerList.Remove(pm);
            }
        }

        public void HireOvenTender(string employeeName)
        {
            OvenTender ot = new OvenTender(employeeName, StoreOven, StoreRack);
            StoreOvenTenderList.Add(ot);

            if (StoreOpen)
            {
                ot.Start();
            }
            else
            {
                ot.SetCurrentTask("Store closed");
            }
        }

        public void FireOvenTender(OvenTender ot)
        {
            if (StoreOvenTenderList.Count > 0)
            {
                ot.Stop();
                StoreOvenTenderList.Remove(ot);
            }
        }

        public void FireLastOvenTender()
        {
            if (StoreOvenTenderList.Count > 0)
            {
                OvenTender ot = StoreOvenTenderList[StoreOvenTenderList.Count - 1];
                ot.Stop();
                StoreOvenTenderList.Remove(ot);
            }
        }

        public void AddOrder(Pizza pizza)
        {
            Order order = new Order(++StoreOrderCount, pizza);
            StoreOrders.Add(order);
        }
    }
}
