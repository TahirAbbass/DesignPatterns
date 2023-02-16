using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento
    {
    class Program
        {
        static void Main (string[] args)
            {
            Originator originator = new Originator();
            CareTaker careTaker = new CareTaker();

            originator.SetState("123");
            careTaker.Add(originator.SaveStateToMemento());

            originator.SetState("456");
            careTaker.Add(originator.SaveStateToMemento());

            originator.SetState("789");
            //careTaker.Add(originator.SaveStateToMemento());

            Console.WriteLine(originator.GetState());

            originator.GetStateFromMemento(careTaker.Pop());
            Console.WriteLine(originator.GetState());

            originator.GetStateFromMemento(careTaker.Pop());
            Console.WriteLine(originator.GetState());
            
            originator.GetStateFromMemento(careTaker.Pop());
            Console.WriteLine(originator.GetState());

            originator.GetStateFromMemento(careTaker.Pop());
            Console.WriteLine(originator.GetState());
            //originator.GetStateFromMemento(careTaker.Get(1));
            //Console.WriteLine(originator.GetState());

            //originator.GetStateFromMemento(careTaker.Get(0));
            //Console.WriteLine(originator.GetState());
            }
        }
    }
