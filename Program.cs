using System;

namespace Firstprogram
{
    class Program
    {
        static void Main(string[] args)
        {
            // Program myProgram = new Program();
            //myProgram.Print();

            //string name = Console.ReadLine();
            //Console.WriteLine($"Hello {name}!");    //String Interploation   
            /*

            Int32 myInt = 54;
            Console.WriteLine(myInt);
            Console.ReadLine();
            */

            //Math Learning

            double x = 50.5;
            double y = 59876;
            double z = 51.6;
            Console.WriteLine(Math.Round(x));
            Console.WriteLine(Math.Round(z,0, MidpointRounding.AwayFromZero));
            Console.WriteLine(Math.Ceiling(x));
            Console.WriteLine(Math.Floor(x));
            Console.WriteLine(Math.Truncate(z));
            Console.WriteLine(Math.Max(x,y));
            Console.WriteLine(Math.Min(x,y));



        }
        /*
        void Print()
        {
            //Console.WriteLine("Some Statement");
        }*/
    }
}
