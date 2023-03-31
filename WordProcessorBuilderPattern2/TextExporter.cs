using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordProcessorBuilderPattern2
    {
    public class TextExporter : IExporter
        {
        private StringBuilder textBuilder = new StringBuilder();

        public void Export (string text)
            {
            textBuilder.Append(text);
            }

        public string GetText ()
            {
            return textBuilder.ToString();
            }
        }
    }
