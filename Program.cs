using System;

namespace Firstprogram
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] grades = { 30, 40, 50, 60, 70 };
            Console.WriteLine(Array.IndexOf(grades, 40));// finds the index of the value
            Console.WriteLine(Array.IndexOf(grades, 55));//returns negative value (-1).


            /*
            // Arrays
            int[] grades = { 30, 40, 23, 10 };
            

            bool found = false;

            for (int i = 0; i< grades.Length; i++)
            {
                if(grades[i]== 50)
                {
                    Console.WriteLine("We Found it");
                    found = true;
                    break;
                }                
            }
            if (!found)
            {
                Console.WriteLine("Not Found.");
            }
            */
            /*
            //Nesting and printing 
            int i = 9;
            while (i >= 0)
            {
                int k = 1;
                while (k >= 0)
                {
                    Console.WriteLine(k + " ");
                    k--;
                }
                Console.WriteLine();
                    i--;
            }
            */


            /*
            // Ternary Operator
            // General Structure: expression? true: false
            //bool correct = true;
            bool correct = false;// check with false value
            int pointsEarned = correct ? 10 : 0;
            Console.WriteLine(pointsEarned);
            
            /*
            Console.WriteLine("Write the name of the countries");
            string countryName = Console.ReadLine();// For user Input
            //string countryName = "Finland"; // For hard typed country Name
            switch(countryName)
            {
                case "Finland":
                    Console.WriteLine("Suomi in Native Language.");
                    break;
                case "Sweden":
                    Console.WriteLine("Ruotsi in Finnish Language.");
                    break;
                default:
                    Console.WriteLine("The Country is inValid.");
                    break;

            }
            */
            /*
            Console.WriteLine("What is your age?");
            int age = Int32.Parse(Console.ReadLine());

            Console.WriteLine("What is the Password?");
            string password = Console.ReadLine();

            if (!(age > 12) || password == "Password123")
            {
                Console.WriteLine("Welcome! You are atleast a teenager and got correct password");
            }
            */

            //Human Class 
            /*

            Human human = new Human();

            human.FirstName = "Adam";
            human.LastName = "Nateshwor";
            Console.WriteLine(human.GetFullName());
            Console.WriteLine("What do you think the name is? ");
            string lastNameGuess = Console.ReadLine();

            Console.WriteLine("Second Guess?");
            string secondLastNameGuess = Console.ReadLine();

            //if (human.LastName == "Nateshwor") //first if statement checked against string
            if(human.LastName == lastNameGuess)// Checks against user input
            {
                Console.WriteLine("You got the Last Name Validate against the string\" Nateshwor\"");
            }else if (human.LastName == secondLastNameGuess)
            {
                Console.WriteLine("This can be put into half of your points");
            }
            else
            {
                Console.WriteLine($"{lastNameGuess} is not matching with the stored Value");
            }
            human.GetFullName();
            */
            // Program myProgram = new Program();
            //myProgram.Print();

            //string name = Console.ReadLine();
            //Console.WriteLine($"Hello {name}!");    //String Interploation   
            /*

            Int32 myInt = 54;
            Console.WriteLine(myInt);
            Console.ReadLine();
            */


            /*
            //Math Learning

            double x = 50.5;
            double y = 59876;
            double z = 51.6;

            //Get Round
            Console.WriteLine(Math.Round(x));
            Console.WriteLine(Math.Round(z,0, MidpointRounding.AwayFromZero));
            Console.WriteLine(Math.Ceiling(x));
            Console.WriteLine(Math.Floor(x));
            Console.WriteLine(Math.Truncate(z));

            //get minimum and maximum
            Console.WriteLine(Math.Max(x,y));
            Console.WriteLine(Math.Min(x,y));

            // get Positive Value
            double b = -543;
            Console.WriteLine(Math.Abs(b)); */

            //Single quotes means character
            //char letter = 'a';

            // Double Quotes means string
            // Wrong char letter = "a";

            /*
            // Working with Tab
            char myTab = '\t';

            Console.WriteLine($"Hi Raj{myTab}Ok{myTab}. Lets see");
            Console.WriteLine("Hello\tRaj");
            */


            /*
            //Working with Strings and Characters

            string name = "Raj";
            //Character array definition and value initialization
            char[] characters = { 'h', 'e', 'l', 'l', 'o' };

            string myString = new string(characters);
            Console.WriteLine(myString);

            string message = $"hei There {name}, Whats going on? {myString} to you";
            Console.WriteLine(message);
            */

            /* string, properties and methods
            ///
            //string declaration
            string name = "raj";
            Console.WriteLine(name.Length);//Length is properties
            Console.WriteLine(name.CompareTo("raj"));//Returns 0
            Console.WriteLine(name.CompareTo("saj"));//Returns -1
            Console.WriteLine(name.CompareTo("qaj"));//Returns 1

            int position = name.IndexOf("j");
            Console.WriteLine(position);//Returns index of j and is 2.
            string Tame = "\t   TrimThis   ";
            Console.WriteLine(Tame.Trim());//Returns space and tab free

            // Split function

            string myStatement = "Hello My Country is Nepal!";
            Console.WriteLine(myStatement.Split(' '));
            string[] words = myStatement.Split(' '); // Split words with space or any characters parameter
            Console.WriteLine(words[4]);

            //Escape string
            string myTesting = "\a\a\a\a\a\a\a\a\a\a\t Lets see the \a what it does"; 
            Console.WriteLine(myTesting); //It makes sound and print the tab
            //For more visit this: https://docs.microsoft.com/en-us/cpp/c-language/escape-sequences?view=msvc-160
            //print the quotes
            Console.WriteLine("hei There \"Raj\""); //prints the following(hei There "Raj")

            //working with verbatim string literals
            string verbatimStatement = @"Hello \tMy Country \is ""Nepal!""";
            Console.WriteLine(verbatimStatement);// prints this statement(Hello \tMy Country \is "Nepal!")
            */







        }
        /*
        void Print()
        {
            //Console.WriteLine("Some Statement");
        }*/
    }
}
