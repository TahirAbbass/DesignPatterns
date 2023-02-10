using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyWeight
    {
    class PointIcon
        {
        public PointType PointType
            {
            get;
            set;
            }

        public int Icon
            {
            get;
            set;
            }

        public PointIcon (PointType pointType, int icon)
            {
            PointType = pointType;
            Icon = icon;
            }

        }
    }
