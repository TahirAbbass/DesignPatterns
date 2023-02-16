using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento
    {
    public class Originator
        {
        private String state;

        public void SetState (String state)
            {
            this.state = state;
            }

        public String GetState ()
            {
            return state;
            }

        public Memento SaveStateToMemento ()
            {
            return new Memento(state);
            }

        public void GetStateFromMemento (Memento memento)
            {
            if (memento != null)
                state = memento.GetState();
            else
                state = "";
            }
        }
    }
