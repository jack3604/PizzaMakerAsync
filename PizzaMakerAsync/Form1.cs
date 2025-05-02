using System.Reflection.Emit;
using Timer = System.Windows.Forms.Timer;

namespace PizzaMakerAsync
{
    public partial class Form1 : Form
    {
        Timer DisplayTimer;
        Timer OrderTimer;

        Store Store;

        string[] Names = { "James", "Olivia", "Michael", "Emma", "William", "Ava", "Benjamin", "Sophia", "Daniel", "Mia" };
        string[] SamplePizzas = { "Cheese", "Pepperoni", "Ham", "Mushroom", "Onion", "Green pepper", "Sausage", "Beef", "Black Olive", "Pineapple", "Chicken" };
        Random random;

        public Form1()
        {
            InitializeComponent();
            random = new Random();

            Store = new Store();
            Store.OpenStore();
            Store.HirePizzaMaker(GetNextName());
            Store.HireOvenTender(GetNextName());

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
            Pizza pizza = new Pizza(GetNextSamplePizza());
            if (Store.IsOpen())
            {
                Store.AddOrder(pizza);
            }
        }

        private void DisplayTimer_Tick(object? sender, EventArgs e)
        {
            RefreshOrderGridView();
            RefreshPizzaMakerGridView();
            RefreshOvenGridView();
            RefreshOvenTenderGridView();
            RefreshRackGridView();
            RefreshTotalPizzasCount();

            RefreshOpenButton();
            RefreshMoneyLabel();
        }

        public void RefreshOpenButton()
        {
            if (Store.IsOpen())
            {
                OpenButton.Text = "Close";
                OpenButton.Refresh();
            }
            else
            {
                OpenButton.Text = "Open";
                OpenButton.Refresh();
            }
        }

        public void RefreshMoneyLabel()
        {
            MoneyLabel.Text = "$" + Store.GetMoney().ToString();
            MoneyLabel.Refresh();
        }

        public void RefreshOrderGridView()
        {
            OrderDataGridView.ReadOnly = false;
            OrderDataGridView.Rows.Clear();

            foreach (Order order in Store.GetOrderQueue().GetOrders())
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

            List<PizzaMaker> PizzaMakerList = Store.GetPizzaMakers();
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

            foreach (Order order in Store.GetOven().GetOrders())
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

            List<OvenTender> OvenTenderList = Store.GetOvenTenders();
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

            List<Order> orders = Store.GetRack().GetOrders();
            for (int i = orders.Count - 1; i >= Math.Max(0, orders.Count - 10); i--)
            {
                Order order = orders[i];
                double bakePercent = order.GetPizza().GetBakeProgress() * 100;
                string bakePercentString = bakePercent.ToString("F0") + "%";
                RackDataGridView.Rows.Add(order.GetId(), order.GetPizza().GetDescription(), bakePercentString);
            }

            RackDataGridView.ReadOnly = true;
            RackDataGridView.Refresh();
        }

        public void RefreshTotalPizzasCount()
        {
            PizzaCountLabel.Text = Store.GetRack().GetOrders().Count.ToString();
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
            if (MultiCheckbox.Checked)
            {
                for (int i = 0; i < 10; i++)
                {
                    Pizza pizza = new Pizza(GetNextSamplePizza());
                    Store.AddOrder(pizza);
                }
            }
            else
            {
                Pizza pizza = new Pizza(GetNextSamplePizza());
                Store.AddOrder(pizza);
            }
        }

        private void SpawnPizzaMakerButton_Click(object sender, EventArgs e)
        {
            Store.HirePizzaMaker(GetNextName());
        }

        private void SpawnOvenTenderButton_Click(object sender, EventArgs e)
        {
            Store.HireOvenTender(GetNextName());
        }

        private void FirePizzaMakerButton_Click(object sender, EventArgs e)
        {
            Store.FireLastPizzaMaker();
        }

        private void FireOvenTenderButton_Click(object sender, EventArgs e)
        {
            Store.FireLastOvenTender();
        }

        private void OpenButton_Click(object sender, EventArgs e)
        {
            if (Store.IsOpen())
            {
                Store.CloseStore();
                OpenButton.Text = "Open";
                OpenButton.Refresh();
            }
            else
            {
                Store.OpenStore();
                OpenButton.Text = "Close";
                OpenButton.Refresh();
            }
        }
    }
}
