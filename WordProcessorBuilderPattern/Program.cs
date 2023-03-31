using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordProcessorBuilderPattern
    {
    class Program
        {
        static void Main (string[] args)
            {
 
            List<(string, string)> elements = new List<(string, string)>
                {
                 ("text", "Hello world"),
                 ("image", "image.png"),
                 ("text", "This is a text element")
                };

            HTMLBuilder htmlBuilder = new HTMLBuilder();

            Director director = new Director(htmlBuilder);

            director.BuildDocument(elements);

            string htmlDocument = director.ExportDocument("html");
            
            Console.WriteLine(htmlDocument);

            TextBuilder textBuilder = new TextBuilder();
            
            director = new Director(textBuilder);


            director.BuildDocument(elements);
            string textDocument = director.ExportDocument("text");
            Console.WriteLine(textDocument);
            }
        }
    }
