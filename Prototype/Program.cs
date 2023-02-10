using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
    {
    class Program
        {
        static void Main (string[] args)
            {
            Console.WriteLine("Prototype Creational Design Patter: Create New objects by copying an existing object");

            Valve valve = new Valve(10);
            valve.Render();

            ContextMenu contextMenu = new ContextMenu();
            Valve newValve = (Valve)contextMenu.Duplicate(valve);

            Console.WriteLine(valve.Error);
            Console.WriteLine(valve.Flow);

            Console.WriteLine(newValve.Error);
            Console.WriteLine(newValve.Flow);
            }
        }
    }
