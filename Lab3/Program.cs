using System;
using System.Collections.Generic;
using System.Threading;

namespace Lab3
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
                BonusUppgift();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }

        private static void Uppgift1()
        {
            Console.WriteLine("----Uppgift 1----");
            Person firstPerson = new Person();
            Person secondPerson = new Person();
            firstPerson.SetName("Mona");
            secondPerson.SetName("Anom");
            Console.WriteLine("The first person's name is {0} and the second's {1}.", firstPerson.GetName(), secondPerson.GetName());
        }
        private static void Uppgift2()
        {
            Console.WriteLine("----Uppgift 2----");
            Circle firstCircle = new Circle();
            Circle secondCircle = new Circle();
            firstCircle.SetDiameter("5,5");
            secondCircle.SetDiameter(2.1);
            Console.WriteLine("The first circle has a diamater of {0} and a circumference of {1:F2}. The second circle has a diameter of {2} and a circumference of {3:F2}.", firstCircle.GetDiameter(), firstCircle.GetCircumference(), secondCircle.GetDiameter(), secondCircle.GetCircumference());
        }
        private static void Uppgift3()
        {
            Console.WriteLine("----Uppgift 3----");
            Point position = new Point();
            position.SetX(5);
            position.SetY(10);
            Console.WriteLine("Position is located on ({0}, {1}).", position.GetX(), position.GetY());
        }
        private static void Uppgift4()
        {
            Console.WriteLine("----Uppgift 4----");
            Point circleCenter = new Point();
            circleCenter.SetX(7);
            circleCenter.SetY(6);
            Circle thirdCircle = new Circle();
            thirdCircle.SetCenter(circleCenter);
            thirdCircle.SetDiameter("10");
            Console.WriteLine("The third circle is centered on ({0}, {1}) with a diameter of {2} and a circumference of {3:F2}.", thirdCircle.GetCenter().GetX(), thirdCircle.GetCenter().GetY(), thirdCircle.GetDiameter(), thirdCircle.GetCircumference());
        }
        private static void Uppgift5()
        {
            Console.WriteLine("----Uppgift 5----");

            MouseButton firstButton = new MouseButton();
            MouseButton secondButton = new MouseButton();
            MouseButton thirdButton = new MouseButton();
            firstButton.SetIntervalDoubleClick(200.0);
            secondButton.SetIntervalDoubleClick(150.5);
            thirdButton.SetIntervalDoubleClick(0);
            firstButton.SetIsScrollable(false);
            secondButton.SetIsScrollable(false);
            thirdButton.SetIsScrollable(true);

            ComputerMouse myMouse = new ComputerMouse();
            myMouse.AddMouseButton(firstButton);
            myMouse.AddMouseButton(secondButton);
            myMouse.AddMouseButton(thirdButton);
            myMouse.SetDpi(2500);
            myMouse.SetSensitivityX(1.1);
            myMouse.SetSensitivityY(1.05);

            Console.WriteLine($"My mouse has {myMouse.GetNumberOfButtons()} buttons, of which {myMouse.GetNumberOfScrollableButtons()} has scroll function and {myMouse.GetNumberOfDoubleClickableButtons()} have double click function. The mouse speed on the horizontal axis is {myMouse.GetMouseSpeedX()} dpi equivalent and {myMouse.GetMouseSpeedY()} on the vertical axis.");
        }
        private static void BonusUppgift()
        {
            Console.WriteLine("----BonusUppgift----");

            Console.WriteLine("How many circles do you want to create?");
            int numberCircles = int.Parse(Console.ReadLine());
            Circle[] circleArray = CircleArrayOperations.GenerateRandomCircleArray(numberCircles);

            Console.WriteLine("There are {0} circles with diameter between 7 and 17.", CircleArrayOperations.CountCirclesWithDiameterBetween(circleArray, minValue: 7, maxValue: 17));
            Console.WriteLine("There are {0} circles with circumference between 2 and 22.", CircleArrayOperations.CountCirclesWithCircumferenceBetween(circleArray, minValue: 2, maxValue: 22));
            circleArray = CircleArrayOperations.ResizeCirclesCloserToOriginThan(circleArray, maxDistanceOrigin: 12);
            circleArray = CircleArrayOperations.CloneMirrorCircles(circleArray);
            circleArray = CircleArrayOperations.CreateNMaxCirclesPerCircle(circleArray, nCircles: 4);

            Console.WriteLine("Input an area to compare to:");
            double minArea = double.Parse(Console.ReadLine());
            Console.WriteLine("There are {0} circles with area larger than {1}.", CircleArrayOperations.CountCirclesWithAreaOver(circleArray, minArea), minArea);

            Console.WriteLine("Input how much you want to displace the circles on the x axis:");
            int xOffset = int.Parse(Console.ReadLine());
            circleArray = CircleArrayOperations.MoveAllCirclesOnX(circleArray, xOffset);

            Console.WriteLine("Input how much you want to displace the circles on the y axis:");
            int yOffset = int.Parse(Console.ReadLine());
            circleArray = CircleArrayOperations.MoveAllCirclesOnY(circleArray, yOffset);

            int option;
            do
            {
                try
                {
                    option = SelectFromMenu();
                    circleArray = ApplySelectedOperationOn(circleArray, option);
                }
                catch (Exception e)
                {
                    option = -1;
                    Console.WriteLine(e);
                    Thread.Sleep(3000);
                }
            } while (option != 0);
        }

        private static int SelectFromMenu()
        {
            Console.Clear();
            Console.WriteLine("Choose an operation to do on the circle array:");
            Console.WriteLine("1- Count circles of a diameter interval.");
            Console.WriteLine("2- Count circles of a circumference interval.");
            Console.WriteLine("3- Adjust diameter to origin crossing on circles closer to it than x.");
            Console.WriteLine("4- Mirror all circles around the origin.");
            Console.WriteLine("5- Create n max diameter circles centered on each circle.");
            Console.WriteLine("6- Count circles of an area larger than x.");
            Console.WriteLine("7- Move all circles along the x axis.");
            Console.WriteLine("8- Move all circles along the y axis.");
            Console.WriteLine("0- Close.");
            return int.Parse(Console.ReadKey().KeyChar.ToString());
        }
        private static Circle[] ApplySelectedOperationOn(Circle[] circleArray, int option)
        {
            switch (option)
            {
                case 1:
                    Console.WriteLine("Min value?");
                    double minValueDiameter = double.Parse(Console.ReadLine());
                    Console.WriteLine("Max value?");
                    double maxValueDiameter = double.Parse(Console.ReadLine());
                    Console.WriteLine("There are {0} circles with diameter between {1} and {2}.", CircleArrayOperations.CountCirclesWithDiameterBetween(circleArray, minValueDiameter, maxValueDiameter), minValueDiameter, maxValueDiameter);
                    Thread.Sleep(3000);
                    break;
                case 2:
                    Console.WriteLine("Min value?");
                    double minValueCircumference = double.Parse(Console.ReadLine());
                    Console.WriteLine("Max value?");
                    double maxValueCircumference = double.Parse(Console.ReadLine());
                    Console.WriteLine("There are {0} circles with circumference between {1} and {2}.", CircleArrayOperations.CountCirclesWithCircumferenceBetween(circleArray, minValue: 2, maxValue: 22), minValueCircumference, maxValueCircumference);
                    Thread.Sleep(3000);
                    break;
                case 3:
                    Console.WriteLine("Max distance from origin?");
                    double maxDistanceOrigin = double.Parse(Console.ReadLine());
                    circleArray = CircleArrayOperations.ResizeCirclesCloserToOriginThan(circleArray, maxDistanceOrigin);
                    break;
                case 4:
                    circleArray = CircleArrayOperations.CloneMirrorCircles(circleArray);
                    break;
                case 5:
                    Console.WriteLine("Number of extra circles per circle?");
                    int nCircles = int.Parse(Console.ReadLine());
                    circleArray = CircleArrayOperations.CreateNMaxCirclesPerCircle(circleArray, nCircles: 4);
                    break;
                case 6:
                    Console.WriteLine("Area to compare to?");
                    double minArea = double.Parse(Console.ReadLine());
                    Console.WriteLine("There are {0} circles with area larger than {1}.", CircleArrayOperations.CountCirclesWithAreaOver(circleArray, minArea), minArea);
                    break;
                case 7:
                    Console.WriteLine("X Offset?");
                    int xOffset = int.Parse(Console.ReadLine());
                    circleArray = CircleArrayOperations.MoveAllCirclesOnX(circleArray, xOffset);
                    break;
                case 8:
                    Console.WriteLine("Y Offset?");
                    int yOffset = int.Parse(Console.ReadLine());
                    circleArray = CircleArrayOperations.MoveAllCirclesOnY(circleArray, yOffset);
                    break;
                default:
                    break;
            }
            return circleArray;
        }
    }
}
