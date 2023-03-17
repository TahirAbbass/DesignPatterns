using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordProcessorBuilderPattern
    {
    class Document
        {
        private List<(string, string)> elements = new List<(string, string)>();

        public void AddText (string text)
            {
            elements.Add(("text", text));
            }

        public void AddImage (string image)
            {
            elements.Add(("image", image));
            }

        public List<(string, string)> GetElements ()
            {
            return elements;
            }
        }
    }
