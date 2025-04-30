using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaMakerAsync
{
    internal class Pizza
    {
        public string Description;
        public double BakeProgress;
        public bool Baked;

        public Pizza(string description)
        {
            Description = description;
            BakeProgress = 0.0;
            Baked = false;
        }

        public string GetDescription() 
        {
            return Description; 
        }

        public double GetBakeProgress()
        {
            return BakeProgress;
        }

        public bool IsBaked()
        {
            return Baked;
        }

        public void SetBakeProgress(double value)
        {
            BakeProgress = value;
        }

        public void AdvanceBakeProgress(double step)
        {
            BakeProgress += step;
            if (BakeProgress >= 1.0) { Baked = true; }
        }
    }
}
