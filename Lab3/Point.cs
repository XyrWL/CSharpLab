using System;

namespace Lab3
{
    public class Point
    {
        int x;
        int y;
  
        public void SetX(int x)
        {
            this.x = x;
        }
        public int GetX()
        {
            return x;
        }
        public void SetY(int y)
        {
            this.y = y;
        }
        public int GetY()
        {
            return y;
        }

        public Point() { }
        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public double GetDistanceTo(Point comparisonPoint)
        {
            double xDistance = comparisonPoint.x - x;
            double yDistance = comparisonPoint.y - y;
            return Math.Sqrt(xDistance * xDistance + yDistance * yDistance);
        }
    }
}
