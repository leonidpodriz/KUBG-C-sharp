using System;
using System.Collections.Generic;
using System.Text;
using Point;

// Описати клас “Point3D” з інформацією про точку у тривимірному просторі, який є похідним від класу “Point” (Лаб. 15)
// Клас “Point3D” містить 2 конструктори ( з параметром та без параметра) набір методів для роботи з об’єктами класу.

namespace laboratory_works
{
    class Point3D : PointDDL
    {
        protected double z;

        public Point3D()
        {
            this.x = 0;
            this.y = 0;
            this.z = 0;
        }

        public Point3D(double x, double y, double z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        public double getZ()
        {
            return z;
        }

        public override string ToString()
        {
            return $"x: {x}; y: {y}, z: {z};";
        }

        public static Point3D operator +(Point3D a, Point3D b)
        {
            return new Point3D(a.x + b.x, a.y + b.y, a.z + b.z);
        }
    }
}
