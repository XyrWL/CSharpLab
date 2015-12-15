using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6
{
    class Car
    {
        string brand, color, type;
        int numberOfGears;

        public string Brand
        {
            get { return brand; }
            set
            {
                if (value != null)
                    brand = value;
            }
        }
        public string Color
        {
            get { return color; }
            set
            {
                if (value != null)
                    color = value;
            }
        }
        public string Type
        {
            get { return type; }
            set
            {
                var isValidType = value.ToLower() == "kupe" || value == "kombi";
                if (value != null && isValidType)
                    type = value;
            }
        }
        public int NumberOfGears
        {
            get { return numberOfGears; }
            set
            {
                if (NumberOfGears > 0)
                    numberOfGears = value;
            }
        }

        public Car()
        {
            Brand = "volvo";
            Color = "red";
            Type = "kupe";
            NumberOfGears = 5;
        }

        public void Drive()
        {
            Console.WriteLine("brum brum");
        }

        //public static explicit operator SUV(Car car) { } //Not allowed to specificy a conversion to a child class.
        
        public override string ToString() => $"Brand:{Brand}, Color:{Color}, Type:{Type}, NumberOfGears:{NumberOfGears}";
    }
}