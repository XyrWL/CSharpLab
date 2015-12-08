using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    class Radio
    {
        static int instanceCount;
        int volume;
        double frequency;

        public static int InstanceCount
        {
            get { return instanceCount; }
            private set
            {
                if (value >= 0)
                    instanceCount = value;
            }
        }
        public bool IsOn { get; set; }
        public int Volume
        {
            get { return volume; }
            set
            {
                var isValidVolume = value >= 0 && value <= 100;
                if (isValidVolume)
                    volume = value;
            }
        }
        public double Frequency
        {
            get { return frequency; }
            set
            {
                var isInFrequencyRange = value > 65.0 && value < 110.0;
                if (isInFrequencyRange)
                    frequency = value;
            }
        }

        static Radio()
        {
            InstanceCount = 0;
        }
        public Radio()
        {
            InstanceCount++;
            IsOn = false;
            Volume = 50;
            Frequency = 100.0;
        }
        public Radio(int volume, double frequency) : this()
        {
            Volume = volume;
            Frequency = frequency;
        }

        public override string ToString()
        {
            if (IsOn)
                return $"Radio(On, Volume:{Volume}, Frequency:{Frequency})";
            else
                return $"Radio(Off, Volume:{Volume}, Frequency:{Frequency})";
        }
    }
}
