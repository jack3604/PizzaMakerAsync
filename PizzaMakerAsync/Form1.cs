using System.Reflection.Emit;
using Timer = System.Windows.Forms.Timer;

namespace PizzaMakerAsync
{
    public partial class Form1 : Form
    {
        List<PizzaMaker> PizzaMakerList;
        List<OvenTender> OvenTenderList;
        Rack PizzaRack;
        Oven PizzaOven;

        Timer DisplayTimer;
        Timer OrderTimer;
        OrderQueue PizzaOrders;
        int OrderCount;

        string[] Names = { "James", "Olivia", "Michael", "Emma", "William", "Ava", "Benjamin", "Sophia", "Daniel", "Mia" };
        string[] SamplePizzas = { "Cheese", "Pepperoni", "Ham", "Mushroom", "Onion", "Green pepper", "Sausage", "Beef", "Black Olive", "Pineapple", "Chicken"};
        Random random;

        public Form1()
        {
            InitializeComponent();
            random = new Random();
            PizzaOrders = new OrderQueue();
            OrderCount = 0;

            PizzaMakerList = new List<PizzaMaker>();
            OvenTenderList = new List<OvenTender>();
            PizzaRack = new Rack();
            PizzaOven = new Oven(0.05);
            PizzaOven.Start();

            PizzaMaker pm = new PizzaMaker(GetNextName(), PizzaOrders, PizzaOven);
            pm.Start();
            PizzaMakerList.Add(pm);

            OvenTender ot = new OvenTender(GetNextName(), PizzaOven, PizzaRack);
            ot.Start();
            OvenTenderList.Add(ot);

            DisplayTimer = new Timer();
            DisplayTimer.Interval = 500;
            DisplayTimer.Tick += DisplayTimer_Tick;
            DisplayTimer.Start();

            OrderTimer = new Timer();
            OrderTimer.Interval = 1000;
            OrderTimer.Tick += OrderTimer_Tick;
            OrderTimer.Start();
        }

        public void OrderTimer_Tick(object? sender, EventArgs e)
        {
            PizzaOrders.Add(new Order(++OrderCount, new Pizza(GetNextSamplePizza())));
        }

        private void DisplayTimer_Tick(object? sender, EventArgs e)
        {
            RefreshOrderGridView();
            RefreshPizzaMakerGridView();
            RefreshOvenGridView();
            RefreshOvenTenderGridView();
            RefreshRackGridView();
            RefreshTotalPizzasCount();
        }

        public void RefreshOrderGridView()
        {
            OrderDataGridView.ReadOnly = false;
            OrderDataGridView.Rows.Clear();

            foreach (Order order in PizzaOrders.GetOrders())
            {
                OrderDataGridView.Rows.Add(order.GetId(), order.GetPizza().GetDescription());
            }

            OrderDataGridView.ReadOnly = true;
            OrderDataGridView.Refresh();
        }

        public void RefreshPizzaMakerGridView()
        {
            PizzaMakerGridView.ReadOnly = false;
            PizzaMakerGridView.Rows.Clear();

            for (int i = 0; i < PizzaMakerList.Count; i++)
            {
                PizzaMakerGridView.Rows.Add(i + 1, PizzaMakerList[i].GetName(), PizzaMakerList[i].GetCurrentTask());
            }

            PizzaMakerGridView.ReadOnly = true;
            PizzaMakerGridView.Refresh();
        }

        public void RefreshOvenGridView()
        {
            OvenGridView.ReadOnly = false;
            OvenGridView.Rows.Clear();

            foreach (Order order in PizzaOven.GetOrders())
            {
                double bakePercent = order.GetPizza().GetBakeProgress() * 100;
                string bakePercentString = bakePercent.ToString("F0") + "%";
                OvenGridView.Rows.Add(order.GetId(), order.GetPizza().GetDescription(), bakePercentString);
            }

            OvenGridView.ReadOnly = true;
            OvenGridView.Refresh();
        }

        public void RefreshOvenTenderGridView()
        {
            OvenTenderGridView.ReadOnly = false;
            OvenTenderGridView.Rows.Clear();

            for (int i = 0; i < OvenTenderList.Count; i++)
            {
                OvenTenderGridView.Rows.Add(i + 1, OvenTenderList[i].GetName(), OvenTenderList[i].GetCurrentTask());
            }

            OvenTenderGridView.ReadOnly = true;
            OvenTenderGridView.Refresh();
        }

        public void RefreshRackGridView()
        {
            RackDataGridView.ReadOnly = false;
            RackDataGridView.Rows.Clear();

            for (int i = PizzaRack.GetOrders().Count - 1; i >= Math.Max(0, PizzaRack.GetOrders().Count - 10); i--)
            {
                Order order = PizzaRack.GetOrders()[i];
                double bakePercent = order.GetPizza().GetBakeProgress() * 100;
                string bakePercentString = bakePercent.ToString("F0") + "%";
                RackDataGridView.Rows.Add(order.GetId(), order.GetPizza().GetDescription(), bakePercentString);
            }

            RackDataGridView.ReadOnly = true;
            RackDataGridView.Refresh();
        }

        public void RefreshTotalPizzasCount()
        {
            PizzaCountLabel.Text = PizzaRack.GetOrders().Count.ToString();
            PizzaCountLabel.Refresh();
        }

        public string GetNextName()
        {
            string name = Names[random.Next(Names.Length)];
            return name;
        }

        public string GetNextSamplePizza()
        {
            string sample = SamplePizzas[random.Next(SamplePizzas.Length)];
            return sample;
        }

        private void WorkButton_Click(object sender, EventArgs e)
        {
            PizzaOrders.Add(new Order(++OrderCount, new Pizza(GetNextSamplePizza())));
        }

        private void SpawnPizzaMakerButton_Click(object sender, EventArgs e)
        {
            PizzaMaker pm = new PizzaMaker(GetNextName(), PizzaOrders, PizzaOven);
            pm.Start();
            PizzaMakerList.Add(pm);
        }

        private void SpawnOvenTenderButton_Click(object sender, EventArgs e)
        {
            OvenTender ot = new OvenTender(GetNextName(), PizzaOven, PizzaRack);
            ot.Start();
            OvenTenderList.Add(ot);
        }

        private void FirePizzaMakerButton_Click(object sender, EventArgs e)
        {
            if (PizzaMakerList.Count > 0)
            {
                PizzaMaker pm = PizzaMakerList[PizzaMakerList.Count - 1];
                pm.Stop();
                PizzaMakerList.Remove(pm);
            }
        }

        private void FireOvenTenderButton_Click(object sender, EventArgs e)
        {
            if (OvenTenderList.Count > 0)
            {
                OvenTender ot = OvenTenderList[OvenTenderList.Count - 1];
                ot.Stop();
                OvenTenderList.Remove(ot);
            }
        }
    }
}
