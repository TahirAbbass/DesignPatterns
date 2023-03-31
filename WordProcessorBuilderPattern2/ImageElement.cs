using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordProcessorBuilderPattern2
    {
    public class ImageElement : IElement
        {
        private string ImageUrl;

        public ImageElement (string imageUrl)
            {
            this.ImageUrl = imageUrl;
            }

        public void Export (IExporter exporter)
            {
            exporter.Export(ImageUrl);
            }
        }
    }
