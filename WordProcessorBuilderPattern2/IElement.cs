﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordProcessorBuilderPattern2
    {
    public interface IElement
        {
        void Export (IExporter exporter);
        }
    }
