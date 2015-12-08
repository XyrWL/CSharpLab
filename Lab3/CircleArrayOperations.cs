using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    public static class CircleArrayOperations
    {
        const double MAX_DIAMETER = 20.0;
        const int MIN_CENTER_X = -15;
        const int MAX_CENTER_X = 15;
        const int MIN_CENTER_Y = -15;
        const int MAX_CENTER_Y = 15;

        public static Circle[] GenerateRandomCircleArray(int numberCircles)
        {
            Random random = new Random();
            Circle[] circleArray = new Circle[numberCircles];
            for (int i = 0; i < numberCircles; i++)
            {
                circleArray[i] = new Circle(diameter: 1 + random.NextDouble() * MAX_DIAMETER - 1, center: new Point(x: random.Next(MIN_CENTER_X, MAX_CENTER_X), y: random.Next(MIN_CENTER_Y, MAX_CENTER_Y)));
            }
            return circleArray;
        }
        public static int CountCirclesWithDiameterBetween(Circle[] circleArray, double minValue, double maxValue)
        {
            int count = 0;
            foreach (Circle circle in circleArray)
            {
                if (circle.GetDiameter() > minValue && circle.GetDiameter() < maxValue)
                    count++;
            }
            return count;
        }
        public static int CountCirclesWithCircumferenceBetween(Circle[] circleArray, double minValue, double maxValue)
        {
            int count = 0;
            foreach (Circle circle in circleArray)
            {
                if (circle.GetCircumference() > minValue && circle.GetCircumference() < maxValue)
                    count++;
            }
            return count;
        }
        public static Circle[] ResizeCirclesCloserToOriginThan(Circle[] circleArray, double maxDistanceOrigin)
        {
            Point originPoint = new Point(x: 0, y: 0);
            foreach (Circle circle in circleArray)
            {
                double distanceOrigin = circle.GetCenter().GetDistanceTo(originPoint);
                if (distanceOrigin < maxDistanceOrigin)
                    circle.SetDiameter(distanceOrigin);
            }
            return circleArray;
        }
        public static Circle[] CloneMirrorCircles(Circle[] circleArray)
        {
            Circle[] newCircleArray = new Circle[circleArray.Length * 2];
            circleArray.CopyTo(newCircleArray, 0);
            for (int i = 0; i < circleArray.Length; i++)
            {
                Point newCenter = new Point((-1) * circleArray[i].GetCenter().GetX(), (-1) * circleArray[i].GetCenter().GetY());
                newCircleArray[circleArray.Length + i] = new Circle(circleArray[i].GetDiameter(), newCenter);
            }
            return newCircleArray;
        }
        public static Circle[] CreateNMaxCirclesPerCircle(Circle[] circleArray, int nCircles)
        {
            Circle[] newCircleArray = new Circle[circleArray.Length * (nCircles+1)];
            circleArray.CopyTo(newCircleArray, 0);
            for (int i = 0; i < circleArray.Length; i++)
            {
                for (int j = 1; j <= nCircles; j++)
                {
                    newCircleArray[circleArray.Length * j + i] = new Circle(MAX_DIAMETER, circleArray[i].GetCenter());
                }
            }
            return newCircleArray;
        }
        public static int CountCirclesWithAreaOver(Circle[] circleArray, double minArea)
        {
            int count = 0;
            foreach (Circle circle in circleArray)
            {
                if (circle.GetArea() > minArea)
                    count++;
            }
            return count;
        }
        public static Circle[] MoveAllCirclesOnX(Circle[] circleArray, int xOffset)
        {
            foreach (Circle circle in circleArray)
            {
                circle.SetCenter(new Point(circle.GetCenter().GetX() + xOffset, circle.GetCenter().GetY()));
            }
            return circleArray;
        }
        public static Circle[] MoveAllCirclesOnY(Circle[] circleArray, int yOffset)
        {
            foreach (Circle circle in circleArray)
            {
                circle.SetCenter(new Point(circle.GetCenter().GetX(), circle.GetCenter().GetY() + yOffset));
            }
            return circleArray;
        }
    }
}
