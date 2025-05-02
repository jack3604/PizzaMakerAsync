using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaMakerAsync
{
    internal class Inventory
    {
        List<InventoryItem> InventoryItems;
        private object lockObj = new object();

        public Inventory() 
        {
            InventoryItems = new List<InventoryItem>();
            AddItem("Dough", 2, 50);
            AddItem("Sauce", 2, 50);
            AddItem("Cheese", 2, 50);
            AddItem("Pepperoni", 1, 20);
            AddItem("Mushroom", 1, 20);
        }

        public List<InventoryItem> GetInventoryItems()
        {
            return InventoryItems;
        }

        public string[] GetItemNames()
        {
            string[] names = new string[InventoryItems.Count];

            for (int i = 0; i < InventoryItems.Count; i++)
            {
                names[i] = InventoryItems[i].GetName();
            }

            return names;
        }

        public void AddItem(string itemName, int itemCost, int amount = 0)
        {
            lock (lockObj)
            {
                InventoryItem item = new InventoryItem(itemName, itemCost, amount);
                InventoryItems.Add(item);
            }
        }

        // TODO
        //public void RemoveItem(string itemName)
        //{
        //    lock (lockObj)
        //    {
        //        InventoryItems.Remove(itemName);
        //    }
        //}

        public int GetItemAmount(string itemName)
        {
            lock (lockObj)
            {
                foreach (InventoryItem item in InventoryItems)
                {
                    if (item.GetName() == itemName)
                    {
                        return item.GetAmount();
                    }
                }
                return 0;
            }
        }

        public void AddItemAmount(string itemName, int amount)
        {
            lock (lockObj)
            {
                foreach (InventoryItem item in InventoryItems)
                {
                    if (item.GetName() == itemName)
                    {
                        item.AddAmount(amount);
                    }
                }
            }
        }

        public bool SubtractItemAmount(string itemName, int amount)
        {
            lock (lockObj)
            {
                foreach (InventoryItem item in InventoryItems)
                {
                    if (item.GetName() == itemName)
                    {
                        return item.SubtractAmount(amount);
                    }
                }
                return false;
            }
        }
    }
}
