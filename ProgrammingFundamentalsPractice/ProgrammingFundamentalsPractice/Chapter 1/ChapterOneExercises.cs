using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingFundamentalsPractice.Chapter_1
{
    public class ChapterOneExercises
    {
        //Compile and execute the sample program from this chapter using the command prompt(the console) and Visual Studio.

        public static void Start()
        {
            Console.WriteLine("Hello C#!");
        }

        //Modify the sample program to print a different greeting, for example "Good Day!".


        public static void Modify()
        {
            Console.WriteLine("Good Day!");
        }

        //Write a console application that prints your first and last name on the console.

        public static void PrintName()
        {
            Console.WriteLine("Victory Uhunmwangho");

        }

        //Write a program that prints the following numbers on the console 1, 101, 1001, each on a new line.


        public static void Exercise7()
        {
            Console.WriteLine("1\n" + "101\n" + "1001");
            //Console.WriteLine("101");
            //Console.WriteLine("1001");
        }
        public static void Exercise8()
        {
            Console.WriteLine(DateTime.Now);
        }
        public static void Exercise9()
        {
            Console.WriteLine(Math.Sqrt(12345));
        }
        public static void Exercise10()
        {
            for(int i = 2; i < 102; i++)
            {
             
                if(i % 2 != 0)
                {
                    Console.Write(-i +"," + " ");
                }
                else
                {
                    Console.Write(i +"," + " ");
                }
            }
        }

        //Write a program that reads your age from the console and prints your age after 10 years.

        public static void Exercise11()
        {
            Console.WriteLine("\nPlease Enter Your age");
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine(age + 10);
        }
    }
}
