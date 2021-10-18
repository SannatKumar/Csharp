using System;
using System.Collections.Generic;
using System.Linq;

namespace Firstprogram
{
    class Program
    {
        static void Main(string[] args)
        {
            //Short Hand Way of Initializng array
            //var grades = new List<int>() { 5, 10 };//short hand of the below code statement
            List<int> grades = new List<int>() { 5, 10 };//list initialize using List keyword from System.Collections.Generic
            Console.WriteLine(grades[0]); // prints 5 


            /*

            //list definition and initialization
            List<int> grades = new List<int>();//list initialize using List keyword from System.Collections.Generic
            grades.Add(5);
            grades.Add(10);
            Console.WriteLine(grades[0]);//rerturns 5 that is added to index 0 of the List grades
            Console.WriteLine(grades[1]);//rerturns 10 that is added to index 1 of the List grades
            */
            /*
            //Handling 2D arrays
            int[,] grades =
            {
                {3, 4, 5, 666, 71 },
                {42, 53, 76, 98, 20 },
                {2, 7, 999, 234, 4 }
            };
            Console.WriteLine(grades.GetLength(0));// prints the length of the rows 3
            Console.WriteLine(grades.GetLength(1)); //prints the length of the columns 5
            for(int i=0; i<grades.GetLength(0); i++)
            {
                for(int k = 0; k<grades.GetLength(1); k++)
                {
                    Console.WriteLine(grades[i, k] + " ");// prints all the values from the array
                }
                Console.WriteLine();
            }
            */
            /*
            //Jagged Arrays
            int[][] grades =
           {
                new int[]{3, 4, 5, 6, },
                new int[]{32, 54, 35, 26, 17, 15, 39 },
                new int[]{1, 49, 15, 6, 78, 101 }
            };
           Console.WriteLine(grades[1] [5]); //prints 15 from the multidimesnional jagged array grades
            Console.WriteLine(grades.Length);// gives the number of rows of jagged array
            Console.WriteLine(grades[2].Length); //gives the column length of index 2 row which is 6 
            */
            /*
            //Initialzing Multi Dimensional Arrays
            int[,] grades =
           {
                {3, 4, 5, 6, 7 },
                {32, 54, 35, 26, 17 },
                {1, 49, 15, 6, 78 }
            };
            Console.WriteLine(grades[0, 2]); //prints 5 from the multidimesnional array grades
            */
            /*
            //Multi-Dimensional Arrays

            int[,] grades = new int[3,5];//3 row and 5 column
            grades[0, 2] = 7; // Provide md array index 0row,2 columns with value 7
            Console.WriteLine(grades[0, 2]); // Prints 7
            */

            /*
            // Array Comparison using System.Linq
            

            int[] grades1 = { 30, 12, 34, 27, 39, 6, 531, 11 };
            int[] grades2 = { 30, 12, 34, 27, 39, 6, 531, 11 };
            //Below Program prints equal
            if (Enumerable.SequenceEqual(grades1, grades2))
            {
                Console.WriteLine("Equal");
            }
            //Below Program prints Not Equal because the arrays values are not same
            int[] grades3 = { 145, 7, 34, 27, 39, 6, 531, 9 };
            if (Enumerable.SequenceEqual(grades1, grades3))
            {
                Console.WriteLine("Equal");
            }
            else
            {
                Console.WriteLine("Not Equal");
            }
            */

            /*
            //Index of Array and sorting, reversing"

            int[] grades = { 30, 15, 16, 234, 6, 55, 2 };
            Console.WriteLine(Array.IndexOf(grades, 234)); //gives 3 because 
            Array.Sort(grades);//Sorts the array
            Console.WriteLine(Array.IndexOf(grades, 234)); //gives 6 because it is sorted

            Array.Reverse(grades);//Reverse the array
            
            Console.WriteLine(Array.IndexOf(grades, 234)); //gives 0 because it is reversed

            for (int i = 0; i < grades.Length; i++)
            {
                Console.WriteLine(grades[i]);
            }
            */




            /*
            //Array Sorting in Ascending order
            int[] grades = { 30, 15, 16, 234, 6, 55, 2};
            Array.Sort(grades);//Sorts the array

            for(int i = 0; i<grades.Length; i++)
            {
                Console.WriteLine(grades[i]);
            }
            */

            /*
            int[] grades = { 30, 40, 50, 60, 70 };
            Console.WriteLine(Array.IndexOf(grades, 40));// finds the index of the value
            Console.WriteLine(Array.IndexOf(grades, 55));//returns negative value (-1).

            */
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
            Console.WriteLine(verbatimStatement);// prints this statement(Hello \tMy Country \is "Nepal!")         */

        }
            /*
            void Print()
            {
                //Console.WriteLine("Some Statement");
            }*/
        }
}
