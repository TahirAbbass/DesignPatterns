﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
    {
    class PngCompressor : ICompressor
        {
        public void Compress (string fileName)
            {
            Console.WriteLine("Compression usig PNG");
            }
        }
    }
