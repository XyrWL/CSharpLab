using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    class Program
    {
        static void Main(string[] args)
        {
            Uppgift1();
            Uppgift2();
            Uppgift3();
            Uppgift4();
            Uppgift5();
            Uppgift6();

            Console.ReadKey();
        }

        private static void Uppgift1()
        {
            Console.WriteLine("-----Uppgift1-----");

            Car myCar = new Car();
            myCar.Type = "kombi";
            myCar.Type = "suv";
            Console.WriteLine($"My car is of the type \"{myCar.Type}\".");
        }
        private static void Uppgift2()
        {
            Console.WriteLine("-----Uppgift2-----");

            Radio myRadio = new Radio();
            myRadio.IsOn = true;
            myRadio.Volume = 75;
            myRadio.Volume = 150;
            myRadio.Frequency = 85.5;
            myRadio.Frequency = 200;
            Console.WriteLine(myRadio);
        }
        private static void Uppgift3()
        {
            Console.WriteLine("-----Uppgift3-----");

            Radio myFirstRadio = new Radio();
            myFirstRadio.IsOn = true;
            Radio mySecondRadio = new Radio(75, 105.5);

            Console.WriteLine(myFirstRadio);
            Console.WriteLine(mySecondRadio);
        }
        private static void Uppgift4()
        {
            Console.WriteLine("-----Uppgift4-----");

            Console.WriteLine($"There have been {Radio.InstanceCount} radios created so far.");
        }
        private static void Uppgift5()
        {
            Console.WriteLine("-----Uppgift5-----");

            Radio myFirstInitializedRadio = new Radio { Frequency = 75.5, Volume = 100, IsOn = true };
            Radio mySecondInitializedRadio = new Radio { Frequency = 90 };
            Console.WriteLine(myFirstInitializedRadio);
            Console.WriteLine(mySecondInitializedRadio);
        }
        private static void Uppgift6()
        {
            Console.WriteLine("-----Uppgift6-----");
            try
            {
                Notebook myNotebook = new Notebook(numberOfPages: 100, width: 30, height: 40, fontWidth: 1, lineHeight: 2);
                string myText = "Utgå från Radio-klassen, och utöka denna så att den håller reda på hur många instanser som skapats. Skapa först ett statiskt fält kallas instanceCount, som du exponerar mha en read-only property. Initiera fältet till 0 i en statisk konstruktor, och räkna upp detta fält i default-konstruktorn. Eftersom denna konstruktor anropas från den andra konstruktorn så kommer alltid fältet räknas upp oavsett vilken constructor som anropas. T.ex. en Cykel-klass har properties Marke, AntalVaxlar, Typ, olika constructors för att initiera olika delar av cykeln i samma anrop, metoder för att byta växel och plinga i klockan(?). Kanske kan man även tänka sig att klassen håller reda på hur många cyklar av varje Typ som skapats? Indata till AntalVaxlar och Typ måste såklart även valideras. Fundera och bygg ut själv. Gå sedan vidare och hitta på egna klasser. Skapa en klass kallad Bil, som har fälten marke, antalVaxlar, farg och typ. Skapa properties för fälten. I set-delen av propertien som manipulerar fältet typ ska du se till att endast värdena kupe eller kombi kan användas, i andra fall ska fältet inte ändras. Skapa instanser och prova att först sätta typ till kombi, därefter till suv, och läs ut vad typ har för värde. I denna uppgift får du själv funder lite på hur klassen ska implementeras. Skapa en klass i en ny fil som du lägger till projektet.Kalla klassen Radio.Denna klass ska modellera en riktig radio, där kontroller finns för volym, av / på, samt frekvensinställning.Fundera på vilka datatyper som ska användas för respektive fält.Validera indata till både volym och frekvens för att se till att dessa håller sig inom rimliga gränser.";
                string remainingText = myNotebook.WriteText(myText);
                Console.WriteLine("Remaining Text:"+remainingText);
                Console.WriteLine("Text:" + myText);
                Console.WriteLine(myNotebook);
                Console.WriteLine("First page:\r\n" + myNotebook[0]);
                Console.WriteLine("Created Pages:" + Page.TotalCount);
                Console.WriteLine("Written Pages:" + Page.WrittenPages);
                Console.WriteLine("Written Lines:" + Line.TotalCount);
                Console.WriteLine("Written Words:" + Word.TotalCount);
                myNotebook[50].WriteText("Hello, adding some more text in this page.");
                Console.WriteLine("\r\nNew page text added on page 51:\r\n" + myNotebook[50]);
                Console.WriteLine("Written Pages:" + Page.WrittenPages);
                Console.WriteLine("Written Lines:" + Line.TotalCount);
                Console.WriteLine("Written Words:" + Word.TotalCount);
                Console.ReadKey();
                for (int i = 0; i < myNotebook.Length; i++)
                {
                    Console.WriteLine($"Page{i+1}:\r\n{myNotebook[i]}");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.TargetSite + ":" + e.Message);
            }
        }

    }
}
