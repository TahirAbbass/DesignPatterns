using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento
    {
    public class CareTaker
        {
        private List<Memento> mementoList = new List<Memento>();

        public void Add (Memento state)
            {
            mementoList.Add(state);
            }

        public Memento Pop ()
            {
            Memento mem = null;
            if (mementoList.Count > 0)
                {
                mem = mementoList.Last();
                mementoList.RemoveAt(mementoList.Count() - 1);
                }
            return mem;
            }

        public Memento Get (int index)
            {
            return mementoList[index];
            }
        }
    }
