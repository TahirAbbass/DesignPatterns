using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
    {
    public class StopState : State
        {

        public void doAction (Context context)
            {
            Console.WriteLine("Player is in stop state");
            context.setState(this);
            }

        public String toString ()
            {
            return "Stop State";
            }
        }
    }
