using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;


namespace ProgrammingFundamentalsPractice.Chapter_12
{
    public class ChapterTwelveExercises
    {
        public static void Exercise7()
        {
            double num = 0;
            try
            {
                Console.Write("Enter number: ");
                num = int.Parse(Console.ReadLine());
                if(num < 0)
                {
                    IOException invalid = new IOException("There is a problem");
                    throw invalid;
                }
                double squareRoot = Math.Sqrt(num);
                Console.WriteLine("The square root of " + num + " is {0} ", squareRoot);
            }
            
            catch (IOException invalid)
            {

                Console.WriteLine("Invalid number");
                
               
            }
            
            finally
            {
                Console.WriteLine("Good Bye.");
            }
        }

        public static void Exercise8()
        {
            Console.Write("Enter start number: ");
            int start = int.Parse(Console.ReadLine());
            Console.Write("Enter end number: ");
            int end = int.Parse(Console.ReadLine());
            ReadNumber(start, end);
        }
        public static void ReadNumber(int start, int end)
        {
            try
            {
                Console.Write("Enter number to be read: ");
                int number = int.Parse(Console.ReadLine());
                if(number < start || number > end)
                {
                    Exception e = new Exception();
                    throw e;
                }
                Console.WriteLine("The number is {0}", number);
            }
            catch(Exception e)
            {
                Console.WriteLine("Number is invalid or out of range");
            }

        }
    }
}
