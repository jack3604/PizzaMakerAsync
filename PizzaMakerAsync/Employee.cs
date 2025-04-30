using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaMakerAsync
{
    internal abstract class Employee
    {
        string Name;
        string CurrentTask;
        CancellationTokenSource CancellationTokenSource;

        public Employee(string name, CancellationTokenSource cancellationTokenSource)
        {
            Name = name;
            CurrentTask = "Waiting";
            CancellationTokenSource = cancellationTokenSource;
        }

        public CancellationTokenSource GetCancellationTokenSource()
        {
            return CancellationTokenSource;
        }

        public abstract void Start();
        public abstract void Stop();

        public string GetName()
        {
            return Name;
        }

        public void SetCurrentTask(string taskDescription)
        {
            CurrentTask = taskDescription;
        }

        public string GetCurrentTask()
        {
            return CurrentTask;
        }
    }
}
