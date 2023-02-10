using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyWeight
    {
    class Point
        {
        public int X
            {
            get; set;
            }

        public int Y
            {
            get; set;
            }

        public PointIcon Icon
            {
            get; set;
            }

        public Point (int x, int y, PointIcon icon)
            {
            X = x;
            Y = y;
            Icon = icon;
            }

        public void Draw ()
            {
            Console.WriteLine("At x={0},y={1} Icon of type {2} is present with value {3}", X, Y, Icon.PointType, Icon.Icon);
            }

        }
    }
