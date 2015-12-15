using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Uppgift1();
                Uppgift2();
                Uppgift3();
                Uppgift4();
                Uppgift5();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }

        private static void Uppgift1()
        {
            Console.WriteLine("----Uppgift 1----");
            float myFloat = 2.5f;
            long myLong = -2L;
            char myChar = 'a';
            string myString = "Hello";
            ulong myUnsignedLong = 5uL;
            Console.WriteLine($"myFloat:{myFloat}, myLong:{myLong}, myChar:{myChar}, myString:{myString}, myUnsignedLong:{myUnsignedLong}");
        }

        private static void Uppgift2()
        {
            Console.WriteLine("----Uppgift 2----");
            int firstNumber = 7;   // 0111
            int secondNumber = 13; // 1101
            Console.WriteLine($"{firstNumber} AND {secondNumber} = {firstNumber & secondNumber}");
            // 0 1 = 0, 1 1 = 1, 1 0 = 0, 1 1 = 1 -> 0101 = 5
            Console.WriteLine($"{firstNumber} OR {secondNumber} = {firstNumber | secondNumber}");
            // 0 1 = 1, 1 1 = 1, 1 0 = 1, 1 1 = 1 -> 1111 = 15
            Console.WriteLine($"{firstNumber} XOR {secondNumber} = {firstNumber ^ secondNumber}");
            // 0 1 = 1, 1 1 = 0, 1 0 = 1, 1 1 = 0 -> 1010 = 10
            Console.WriteLine($"{firstNumber} Shift Left 1bit = {firstNumber << 1}");
            // 0111 -> 1110 = 14
            Console.WriteLine($"{firstNumber} Shift Right 1bit = {firstNumber >> 1}");
            // 0111 -> 0011 = 3
        }

        private static void Uppgift3()
        {
            Console.WriteLine("----Uppgift 3----");
            Point myPoint = new Point(5, 10);
            Point3D my3DPoint = myPoint;
            Console.WriteLine($"myPoint({myPoint}), my3DPoint({my3DPoint})");
            Point myPointFrom3D = (Point)my3DPoint;
            Console.WriteLine($"myPointFrom3D({myPointFrom3D})");
        }

        private static void Uppgift4()
        {
            Console.WriteLine("----Uppgift 4----");
            MyDoubleType mdt1 = new MyDoubleType(5);
            MyDoubleType mdt2 = mdt1 + 5;
            MyDoubleType mdt3 = mdt1 + mdt2;
            MyDoubleType mdt4 = new MyDoubleType(5);
            Console.WriteLine("{0}, {1}, {2}, {3}, {4}", mdt1, mdt2, mdt3, mdt1 > mdt2, mdt1 == mdt4);
        }

        private static void Uppgift5()
        {
            Console.WriteLine("----Uppgift 5----");
            Console.WriteLine("[...]");
        }
    }
}