using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordProcessorBuilderPattern
    {
/*    interface IPage
        {
        
        }*/

    interface IDocument
        {
        void AddText (string line);
        void AddImage (string img);
        List<(string, string)> GetElements ();
        }

    class Document : IDocument
        {

        private List<(string, string)> Elements = new List<(string, string)>();

        public void AddText (string text)
            {
            Elements.Add(("text", text));
            }

        public void AddImage (string image)
            {
            Elements.Add(("image", image));
            }

        public List<(string, string)> GetElements ()
            {
            return Elements;
            }
        }
    }
