using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordProcessorBuilderPattern2
    {
    class Program
        {
        static void Main ()
            {
            var builder = new DocumentBuilder();
            builder.AddElement(new TextElement("Hello World!"));
            builder.AddElement(new ImageElement("pic.jpg"));

            var htmlExporter = new HtmlExporter();
            builder.Export(htmlExporter);
            var htmlDocument = htmlExporter.GetHtml();

            var textExporter = new TextExporter();
            builder.Export(textExporter);
            var textDocument = textExporter.GetText();

            }
        }
    }
