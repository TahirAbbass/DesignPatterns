using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordProcessorSample
    {
    class Exporter
        {
        public void Export (IDocument document, IExportStrategy strategy)
            {
            strategy.Export(document);
            }
        }
    }
