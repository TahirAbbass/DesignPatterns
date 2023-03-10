using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Add2
    {
    public interface IObserver
        {
        // Receive update from subject
        void Update (ISubject subject);
        }
    public interface ISubject
        {
        // Attach an observer to the subject.
        void Attach (IObserver observer);

        // Detach an observer from the subject.
        void Detach (IObserver observer);
        // Notify all observers about an event.
        void Notify ();
        }
    // The Subject owns some important state and notifies observers when the
    // state changes.
    public class Store : ISubject
        {
        // For the sake of simplicity, the Subject's state, essential to all
        // subscribers, is stored in this variable.
        public List<int> Items = new List<int>();

        // List of subscribers. In real life, the list of subscribers can be
        // stored more comprehensively (categorized by event type, etc.).
        private List<IObserver> _observers = new List<IObserver>();

        // The subscription management methods.
        public void Attach (IObserver observer)
            {
            Console.WriteLine("Subject: Attached an observer.");
            this._observers.Add(observer);
            }

        public void Detach (IObserver observer)
            {
            this._observers.Remove(observer);
            Console.WriteLine("Subject: Detached an observer.");
            }
        // Trigger an update in each subscriber.
        public void Notify ()
            {
            Console.WriteLine("Subject: Notifying observers...");

            foreach (var observer in _observers)
                {
                observer.Update(this);
                }
            }
        // that triggers a notification method whenever something important is
        public void AddItem (int id)
            {
            Console.WriteLine("\nSubject: Adding new Item.");
            this.Items.Add(id);
            this.Notify();
            }
        }

    // Concrete Observers react to the updates issued by the Subject they had
    // been attached to.
    class Customer : IObserver
        {
        public void Update (ISubject subject)
            {
             Console.WriteLine("Customer: Reacted to the event.");
            }
        }
    class Program
        {
        static void Main (string[] args)
            {
            // The client code.
            var store = new Store();
            //store.AddItem(1);

            var observer = new Customer();
            store.Attach(observer);

            //store.AddItem(2);

            var observer2 = new Customer();
            store.Attach(observer2);

            store.AddItem(2);

            }
        }
    }
