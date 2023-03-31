using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
    {
    class Program
        {
        static void Main (string[] args)
            {
            //publisher
            Store store = new Store();

            //subscribers
            Customer customer1 = new Customer();
            Customer customer2 = new Customer();

            store.AddItem(1);

            store.Attach(customer1);

            store.AddItem(2);

            store.Attach(customer2);

            store.AddItem(3);

            store.Detach(customer1);
            store.AddItem(4);

            }
        }
    }
