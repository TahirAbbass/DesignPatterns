using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordProcessorBuilderPattern
    {
    class Director
        {
        private Builder builder;

        public Director (Builder builder)
            {
            this.builder = builder;
            }

        public void BuildDocument (List<(string, string)> elements)
            {
            foreach ((string type, string value) in elements)
                {
                if (type == "text")
                    {
                    builder.AddText(value);
                    }
                else if (type == "image")
                    {
                    builder.AddImage(value);
                    }
                }
            }

        public string ExportDocument (string format)
            {
            if (format == "html")
                {
                string result = builder.GetResult();
                return $"<!DOCTYPE html><html><body>{result}</body></html>";
                }
            else if (format == "text")
                {
                string result = builder.GetResult();
                return result;
                }
            else
                {
                throw new ArgumentException($"Unsupported format: {format}");
                }
            }
        }
    }
