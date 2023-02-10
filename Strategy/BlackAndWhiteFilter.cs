using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
    {
    class BlackAndWhiteFilter : IFilter
        {
        public void Apply (string fileName)
            {
            Console.Write("Apply Black & White filter");
            }
        }
    }
