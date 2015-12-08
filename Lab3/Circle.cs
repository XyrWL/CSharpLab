using System;

namespace Lab3
{
    public class Circle
    {
        double diameter;
        Point center;
                
        public void SetDiameter(string diameter)
        {
            double newDiameter;
            if (diameter != null)
                newDiameter = double.Parse(diameter);
            else
                throw new ArgumentNullException("diameter");            
            if (newDiameter >= 0)
                this.diameter = newDiameter;
            else
                throw new ArgumentException("Value is not a positive double", "diameter");            
        }
        public void SetDiameter(double diameter)
        {
            if (diameter >= 0)
                this.diameter = diameter;
            else
                throw new ArgumentException("Value is not a positive double", "diameter");
        }
        public double GetDiameter()
        {
            return diameter;
        }        
        public void SetCenter(Point p)
        {
            if(p != null)
                center = p;
            else
                throw new ArgumentNullException("center");
        }
        public Point GetCenter()
        {
            return center;
        }

        public Circle() { }
        public Circle(double diameter, Point center)
        {
            this.diameter = diameter;
            this.center = center;
        }

        public double GetCircumference()
        {
            return diameter * Math.PI;
        }
        public double GetArea()
        {
            return (diameter / 2) * (diameter / 2) * Math.PI;
        }
    }
}
