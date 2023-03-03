using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordProcessorSample
    {
    class Program
        {
        static void Main (string[] args)
            {
            WordProcessor processor = new WordProcessor();

            string str = "this is first line";
            processor.AddLine(str);

            byte[] byt = new byte[str.Length];
            for (int i = 0; i < str.Length; i++)
                {
                byt[i] = Convert.ToByte(str[i]);
                }
            processor.AddImage(byt);

            Exporter exporter = new Exporter();
            HTMLExport hTMLExport = new HTMLExport();

            exporter.Export(processor, hTMLExport);

            TextExport textExport = new TextExport();

            exporter.Export(processor, textExport);
            }
        }
    }
