using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
    {
    class Program
        {
        static void Main (string[] args)
            {
            Console.WriteLine("Strategy Behavioral Design Pattern: Encapsulate an algorithm inside the class");

            ImageStorage imageStorage = new ImageStorage();

            imageStorage.Store("xyz", new PngCompressor(), new BlackAndWhiteFilter());
            }
        }
    }
