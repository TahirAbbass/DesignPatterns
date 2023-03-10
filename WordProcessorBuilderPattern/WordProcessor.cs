using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordProcessorSample
    {
    //enum  ExportFormat
    //    {
    //    TXT,
    //    HTML
    //    }

    interface IDocument
        {
        void AddLine (string line);
        void AddImage (byte[] img);
        List<string> GetLines ();
        List<byte[]> GetImages ();
        }


    class WordProcessor : IDocument
        {
        private List<string> Lines = new List<string>();
        private List<byte[]> Images = new List<byte[]>();

        public void AddLine (string line)
            {
            Lines.Add(line);
            }

        public void AddImage (byte[] img)
            {
            Images.Add(img);
            }

        public List<string> GetLines ()
            {
            return Lines;
            }

        public List<byte[]> GetImages ()
            {
            return Images;
            }

        }
    }
