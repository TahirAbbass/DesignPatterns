using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
    {
    public class JpegCompressor : ICompressor
        {
        public void Compress (string fileName)
            {
            Console.WriteLine("Compression using JPEG");
            }
        }
    }
