using System;
using System.Collections.Generic;
using System.Text;

namespace laboratory_works
{
    class Point
    {
        protected double x, y;

        public Point()
        {
            x = 0;
            y = 0;
        }

        public Point(double x, double y)
        {
            this.x = x;
            this.y = y;
        }

        public double getX()
        {
            return x;
        }

        public double getY()
        {
            return y;
        }

        public override string ToString()
        {
            return $"x: {x}; y: {y};";
        }
    }
}
