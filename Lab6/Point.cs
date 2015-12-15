using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6
{
    class Point
    {
        public int X;
        public int Y;

        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }

        public static implicit operator Point3D(Point point)
        {
            return new Point3D(x: point.X, y: point.Y, z: 0);
        }
        public override string ToString()
        {
            return $"X:{X}, Y:{Y}";
        }
    }
}
