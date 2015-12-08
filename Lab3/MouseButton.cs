using System;

namespace Lab3
{
    public class MouseButton
    {
        bool isScrollable;
        double intervalDoubleClick;

        public void SetIsScrollable(bool isScrollable)
        {
            this.isScrollable = isScrollable;
        }
        public bool GetIsScrollable()
        {
            return isScrollable;
        }
        public void SetIntervalDoubleClick(double intervalDoubleClick)
        {
            if (intervalDoubleClick >= 0)
                this.intervalDoubleClick = intervalDoubleClick;
            else
                throw new ArgumentException("Value is not a positive double or zero", "intervalDoubleClick");
        }
        public double GetIntervalDoubleClick()
        {
            return intervalDoubleClick;
        }
        public bool GetIsDoubleClickable()
        {
            if (intervalDoubleClick > 0)
                return true;
            else
                return false;
        }
    }
}