using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
    {
    public class Store : ISubject
        {
        private List<IObserver> Observers = new List<IObserver>();
        public List<int> Items = new List<int>();

        public void AddItem (int id)
            {
            Console.WriteLine("Subject: Adding new Item.");
            this.Items.Add(id);
            this.Notify();
            }

        public void Attach (IObserver observer)
            {
            Console.WriteLine("Subject: Attached an observer. \n");
            this.Observers.Add(observer);
            }

        public void Detach (IObserver observer)
            {
            Console.WriteLine("Subject: Removed an observer. \n");
            this.Observers.Remove(observer);
            }

        public void Notify ()
            {
            Console.WriteLine("Subject: Notifying observers: \n");
            foreach (var observer in Observers)
                {
                observer.Update(this);
                }
            }
        }
    }
