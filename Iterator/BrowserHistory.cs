using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator
    {
    public class BrowserHistory
        {
        private List<string> _urls;

        public BrowserHistory ()
            {
            _urls = new List<string>();
            
            }

        public void push (string url)
            {
            this._urls.Add(url);
            }

        public void pop (string url)
            {
            this._urls.Remove(url);
            }

        public IIterator<string> CreateIterator ()
            {
            return new ArrayIterator<string>(this._urls);
            }
        }
    }
