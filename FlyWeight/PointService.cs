using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyWeight
    {
    class PointService
        {
        public PointIconFactory PointIconFactory
            {
            get; set;
            }

        public PointService (PointIconFactory pointIconFactory)
            {
            PointIconFactory = pointIconFactory;
            }

        public List<Point> GetPoint ()
            {
            List<Point> points = new List<Point>();

            Point p = new Point(1, 2, PointIconFactory.GetPointIcon(PointType.Cafe));

            points.Add(p);

            return points;
            }

        }
    }
