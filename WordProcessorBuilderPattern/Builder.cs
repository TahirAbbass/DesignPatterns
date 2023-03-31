using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordProcessorBuilderPattern
    {
    abstract class Builder
        {
        public abstract void AddText (string text);
        public abstract void AddImage (string image);
        public abstract string GetResult ();
        }

    class HTMLBuilder : Builder
        {
        private Document document = new Document();

        public override void AddText (string text)
            {
            document.AddText($"<p>{text}</p>");
            }

        public override void AddImage (string image)
            {
            document.AddImage($"<img src=\"{image}\"/>");
            }

        public override string GetResult ()
            {
            return string.Join("\n", document.GetElements().Select(e => $"<{e.Item1}>{e.Item2}</{e.Item1}>"));
            }
        }

    class TextBuilder : Builder
        {
        private Document document = new Document();

        public override void AddText (string text)
            {
            document.AddText(text);
            }

        public override void AddImage (string image)
            {

            }

        public override string GetResult ()
            {
            return string.Join("\n", document.GetElements().Where(e => e.Item1 == "text").Select(e => e.Item2));
            }
        }
    }
