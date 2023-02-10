using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator
    {
    class Program
        {
        static void Main (string[] args)
            {
            BrowserHistory browserHistory = new BrowserHistory();
            browserHistory.push("chatgpt");
            browserHistory.push("AI");
            browserHistory.push("google");

            var urlIterator = browserHistory.CreateIterator();

            while (urlIterator.HasNext())
                {
                Console.WriteLine(urlIterator.Current());
                urlIterator.Next();
                }

            }
        }
    }
