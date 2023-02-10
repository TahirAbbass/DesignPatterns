using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyWeight
    {
    class PointIconFactory
        {

        public Dictionary<PointType, PointIcon> Map
            {
            get; set;
            }

        public PointIconFactory ()
            {
            Map = new Dictionary<PointType, PointIcon>();
            }

        public PointIcon GetPointIcon (PointType pointType)
            {

            if (!Map.ContainsKey(pointType))
                {
                PointIcon pointIcon = new PointIcon(pointType, 5);
                Map.Add(pointType, pointIcon);
                }

            return Map[pointType];
            }

        }
    }
