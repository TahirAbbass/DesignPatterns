using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
    {
    public class Customer : IObserver
        {
        public void Update (ISubject subject)
            {
            Console.WriteLine("Observer: Customer Updated");
            }
        }
    }
