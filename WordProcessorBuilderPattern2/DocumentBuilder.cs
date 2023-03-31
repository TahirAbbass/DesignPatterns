using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordProcessorBuilderPattern2
    {
    // The builder class that creates a document and adds elements to it
    public class DocumentBuilder
        {
        private List<IElement> Elements = new List<IElement>();

        public void AddElement (IElement element)
            {
            Elements.Add(element);
            }

        public void Export (IExporter exporter)
            {
            foreach (var element in Elements)
                {
                element.Export(exporter);
                }
            }
        }
    }
