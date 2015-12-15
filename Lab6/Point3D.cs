using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6
{
    class Point3D
    {
        public int X;
        public int Y;
        public int Z;

        public Point3D(int x, int y, int z)
        {
            X = x;
            Y = y;
            Z = z;
        }

        public static explicit operator Point(Point3D point3D)
        {
            return new Point(x: point3D.X, y: point3D.Y);
        }
        public override string ToString()
        {
            return $"X:{X}, Y:{Y}, Z:{Z}";
        }
    }
}
