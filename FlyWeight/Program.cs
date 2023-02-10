using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyWeight
    {
    class Program
        {
        static void Main (string[] args)
            {

            List<Point> points = new List<Point>();

            PointService pointService = new PointService(new PointIconFactory());

            points = pointService.GetPoint();

            points.ForEach(x => x.Draw());

            points = pointService.GetPoint();

            points.ForEach(x => x.Draw());
            }
        }
    }
