namespace Lab6
{
    class MyDoubleType
    {
        private double doubleValue;

        public double DoubleValue
        {
            get { return doubleValue; }
            set { doubleValue = value; }
        }

        public MyDoubleType(double doubleValue)
        {
            DoubleValue = doubleValue;
        }

        public static MyDoubleType operator +(MyDoubleType first, MyDoubleType second) => new MyDoubleType(first.DoubleValue + second.DoubleValue);
        public static MyDoubleType operator +(MyDoubleType first, double second) => new MyDoubleType(first.DoubleValue + second);
        public static double operator +(double first, MyDoubleType second) => first + second.DoubleValue;

        public static MyDoubleType operator -(MyDoubleType first, MyDoubleType second) => new MyDoubleType(first.DoubleValue - second.DoubleValue);
        public static MyDoubleType operator -(MyDoubleType first, double second) => new MyDoubleType(first.DoubleValue - second);
        public static double operator -(double first, MyDoubleType second) => first - second.DoubleValue;

        public static MyDoubleType operator *(MyDoubleType first, MyDoubleType second) => new MyDoubleType(first.DoubleValue * second.DoubleValue);
        public static MyDoubleType operator *(MyDoubleType first, double second) => new MyDoubleType(first.DoubleValue * second);
        public static double operator *(double first, MyDoubleType second) => first * second.DoubleValue;

        public static MyDoubleType operator /(MyDoubleType first, MyDoubleType second) => new MyDoubleType(first.DoubleValue / second.DoubleValue);
        public static MyDoubleType operator /(MyDoubleType first, double second) => new MyDoubleType(first.DoubleValue / second);
        public static double operator /(double first, MyDoubleType second) => first / second.DoubleValue;

        public static bool operator ==(MyDoubleType first, MyDoubleType second) => first.DoubleValue == second.DoubleValue;
        public static bool operator ==(MyDoubleType first, double second) => first.DoubleValue == second;
        public static bool operator ==(double first, MyDoubleType second) => first == second.DoubleValue;

        public static bool operator !=(MyDoubleType first, MyDoubleType second) => first.DoubleValue == second.DoubleValue;
        public static bool operator !=(MyDoubleType first, double second) => first.DoubleValue == second;
        public static bool operator !=(double first, MyDoubleType second) => first == second.DoubleValue;

        public static bool operator >(MyDoubleType first, MyDoubleType second) => first.DoubleValue > second.DoubleValue;
        public static bool operator >(MyDoubleType first, double second) => first.DoubleValue > second;
        public static bool operator >(double first, MyDoubleType second) => first > second.DoubleValue;

        public static bool operator <(MyDoubleType first, MyDoubleType second) => first.DoubleValue < second.DoubleValue;
        public static bool operator <(MyDoubleType first, double second) => first.DoubleValue < second;
        public static bool operator <(double first, MyDoubleType second) => first < second.DoubleValue;

        public static bool operator >=(MyDoubleType first, MyDoubleType second) => first.DoubleValue > second.DoubleValue;
        public static bool operator >=(MyDoubleType first, double second) => first.DoubleValue > second;
        public static bool operator >=(double first, MyDoubleType second) => first > second.DoubleValue;

        public static bool operator <=(MyDoubleType first, MyDoubleType second) => first.DoubleValue < second.DoubleValue;
        public static bool operator <=(MyDoubleType first, double second) => first.DoubleValue < second;
        public static bool operator <=(double first, MyDoubleType second) => first < second.DoubleValue;

        public override string ToString() => $"{DoubleValue}";
    }
}
