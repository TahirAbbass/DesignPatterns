using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordProcessorSample
    {
    interface IExportStrategy
        {
        void Export (IDocument document);
        }

    class HTMLExport : IExportStrategy
        {
        public void Export (IDocument document)
            {
            Console.WriteLine("\n Exporting Data in HTML format:");
            //fetch text and images to export
            List<string> lines = document.GetLines();
            foreach (var li in lines)
                {
                Console.WriteLine(li);
                }
            List<byte[]> imgs = document.GetImages();
            foreach (var img in imgs)
                {
                foreach (var byt in img)
                    {
                    Console.WriteLine(byt);
                    }
                }

            }
        }

    class TextExport : IExportStrategy
        {
        public void Export (IDocument document)
            {
            Console.WriteLine("\n Exporting in Text format");
            //fetch only txt to export
            List<string> lines = document.GetLines();
            foreach (var li in lines)
                {
                Console.WriteLine(li);
                }
            }
        }
    }
