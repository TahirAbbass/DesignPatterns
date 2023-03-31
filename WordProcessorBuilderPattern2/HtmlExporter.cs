using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordProcessorBuilderPattern2
    {
    public class HtmlExporter : IExporter
        {
        private StringBuilder htmlBuilder = new StringBuilder();

        public void Export (string element)
            {
            htmlBuilder.Append(element);
            }

        public string GetHtml ()
            {
            return htmlBuilder.ToString();
            }
        }
    }
