using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordProcessorBuilderPattern2
    {
    public class TextElement : IElement
        {
        private string Text;

        public TextElement (string text)
            {
            this.Text = text;
            }

        public void Export (IExporter exporter)
            {
            exporter.Export(Text);
            }
        }
    }
