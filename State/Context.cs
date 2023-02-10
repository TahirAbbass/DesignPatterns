using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
    {
    public class Context
        {
        private State state;

        public Context ()
            {
            state = null;
            }

        public void setState (State state)
            {
            this.state = state;
            }

        public State getState ()
            {
            return state;
            }
        }

    }
