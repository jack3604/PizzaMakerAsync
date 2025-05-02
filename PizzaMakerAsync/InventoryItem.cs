using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaMakerAsync
{
    internal class InventoryItem
    {
        string ItemName;
        int ItemCost;
        int CurrentAmount;
        object lockObj = new object();

        public InventoryItem(string itemName, int itemCost, int currentAmount = 0)
        {
            ItemName = itemName;
            ItemCost = itemCost;
            CurrentAmount = currentAmount;
        }

        public string GetName()
        {
            lock (lockObj)
            {
                return ItemName;
            }
        }

        public int GetCost()
        {
            lock (lockObj)
            {
                return ItemCost;
            }
        }

        public int GetAmount()
        {
            lock (lockObj)
            {
                return CurrentAmount;
            }
        }

        public void AddAmount(int amount)
        {
            lock (lockObj)
            {
                CurrentAmount += amount;
            }
        }

        public bool SubtractAmount(int amount)
        {
            lock (lockObj)
            {
                if (CurrentAmount - amount >= 0)
                {
                    CurrentAmount -= amount;
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
    }
}
