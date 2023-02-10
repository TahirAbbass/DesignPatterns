using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
    {
    public class StartState : State
        {

        public void doAction (Context context)
            {
            Console.Write("Player is in start state");
            context.setState(this);
            }

        public String toString ()
            {
            return "Start State";
            }
        }
    }
