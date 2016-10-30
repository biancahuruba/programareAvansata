using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//facand proprietatile protected, ele devin inaccesibile in main
//facand si clasa protected, primim eroarea ca in namespace clasele nu pot fi declarate private, protected sau protected-internal
//facand clasa si proprietatile internal, programul ruleaza si afiseaza pe consola
namespace ConsoleApplication1
{
    internal class Mercedes : AbstractCar {
        private string _Description;
        private int _Price;
        private int counter;
        public static int staticcounter;
        public Mercedes() {
            _Description ="E Class";
            _Price =67000;
        }
        public Mercedes(int n) { }

        public void PrintMercedesLogo() {

            Console.WriteLine("This is from Mercedes");
            counter++;
            if (counter == 3) { return; }
            PrintMercedesLogo();
        }

        public void PrintNewMercedes(int c) {
            if (c == 3) { return; }
            Console.WriteLine("Merces no=" + c);
        }

        public string StartEngine()
        {
            string start = "Engine started";
            return start;
        }

        public int ShowRemainingNoOfKM(int noOfFuelLiters, int Consumption)
        {
            int  result = 0;
            result = noOfFuelLiters / Consumption * 100;
            return result; ;
        }
        internal int Price {
            get { return _Price; }
            set { _Price = value; }
        }
        internal string Description {
            get { return _Description; }
            set { _Description = value; }
        }

    }
    interface ICar {
    }
    public abstract class AbstractCar : ICar {
    }
    struct EngineStruct {
    }

    class FIZBUZ {

        public static string ShowFizBuz(int recivednr) {
            if (recivednr % 15 == 0) { return "Fiz Buz"; }
         else if (recivednr % 3 == 0) { return "Fiz"; }
          else if (recivednr % 5 == 0) { return "Buz"; }
            else { return "" + recivednr; }
        }
    }
    class Program
    {
        static int counter;
        static void PrintLogo() {
            Console.WriteLine("I am learning C#");
            Console.WriteLine("C# is great!");
            PrintLogo2();
        }

        static void PrintLogo(int i) {
            Console.WriteLine(i);
        }

        static void PrintLogo2() {
            counter++;
            if (counter == 3) { return; }
            Console.WriteLine("This is PrintLogo2!");
            PrintLogo2();
        }
        static void Main(string[] args)
        {
            //Curs1

            //Console.WriteLine("This is my first C# project!");
            //Mercedes mercedes = new Mercedes();
            //EngineStruct engine1 = new EngineStruct();
            //ICar car = new Mercedes();
            //AbstractCar car2 = new Mercedes(5);
            //Console.WriteLine("Mercedes is: " + mercedes.Description);
            //Console.WriteLine("Mercedes costs: " + mercedes.Price);

            //Curs2

            //PrintLogo();
            //PrintLogo(1);
            //Mercedes mercedes1 = new Mercedes();
            ////mercedes.PrintMercedesLogo();
            //mercedes1.PrintNewMercedes(Mercedes.staticcounter++);
            //Mercedes mercedes2 = new Mercedes();
            //mercedes2.PrintNewMercedes(Mercedes.staticcounter++);
            //Mercedes mercedes3 = new Mercedes();
            //mercedes3.PrintNewMercedes(Mercedes.staticcounter++);
            //Mercedes mercedes4 = new Mercedes();
            //mercedes4.PrintNewMercedes(Mercedes.staticcounter++);
            //Mercedes.StartEngine();
            //mercedes1.ShowRemainingNoOfKM(23, 20);
            //mercedes2.ShowRemainingNoOfKM(10, 7);
            //double nrOfKMLeft = mercedes4.ShowRemainingNoOfKM(10,7);
            //Console.WriteLine("Remind km=" + nrOfKMLeft);
            //Console.WriteLine(FIZBUZ.ShowFizBuz(15));
             //
            //Tema Curs 2
            //Exercitiul 1
            Mercedes mercedes1 = new Mercedes();
            //mercedes1.StartEngine();

            //Exercitiul 2
            //metoda nu calculeaza corect deoarece la impartirea: noOfFuelLiters / Consumption
            //se ia intregul impartirii si iqnora partea fractionara
            //acest lucru se intampla deoarece noi lucram cu valori int
            //mercedes1.ShowRemainingNoOfKM(23, 20);
            //mercedes1.ShowRemainingNoOfKM(10, 7);

            //Exercitiul 3
            //metoda ShowRemainingNoOfKM inca nu functioneaza corect, datorita impartirii mentionate mai sus
            Console.WriteLine(mercedes1.StartEngine());
            Console.WriteLine("Remaining km: " + mercedes1.ShowRemainingNoOfKM(23, 20));
            Console.WriteLine("Remaining km: " + mercedes1.ShowRemainingNoOfKM(23, 20));
            Console.ReadKey();
        }
    }
}
