using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
    {
    class Program
        {
        static void Main (string[] args)
            {
            Context context = new Context();

            StartState startState = new StartState();
            startState.doAction(context);

            Console.WriteLine(context.getState());

            StopState stopState = new StopState();
            stopState.doAction(context);

            Console.WriteLine(context.getState());
            }
        }
    }
