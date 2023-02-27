using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingFundamentalsPractice.Chapter_11
{
    public class ChapterElevenExercises
    {
        public static void Exercise1()
        {
            Console.WriteLine("Enter year: ");
            int year = int.Parse(Console.ReadLine());

            if(DateTime.IsLeapYear(year))
            {
                Console.WriteLine("Leap Year");

            }
            else
            {
                Console.WriteLine("Not a Leap Year");
            }
            
            
        }
        public static void Exercise2()
        {
            Random randNum = new Random();
            for(int num = 1; num<=10; num++)
            {
                int randomNumber = randNum.Next(100, 200);
                Console.Write("{0}", randomNumber +  ", ");
            }
        }
        public static void Exercise3()
        {
           DayOfWeek day =  DateTime.Today.DayOfWeek;
            Console.WriteLine(day);
        }
        public static void Exercise4()
        {
            int  timePassed = Environment.TickCount;
            Console.WriteLine(timePassed);
        }
        public static void Exercise5()
        {
            Console.WriteLine("Enter a and b");
            double a = int.Parse(Console.ReadLine());
            double b = int.Parse(Console.ReadLine());
            double c = Math.Sqrt(a) + Math.Sqrt(b);
            Console.WriteLine(c);
        }
        public static void Exercise9()
        {
            DayOfWeek endDate = DayOfWeek.Wednesday;
            DateTime i = DateTime.Now.Date;
             
            int counter = 0;
            while(i.DayOfWeek != endDate) 
            {
               
                if(i.DayOfWeek == DayOfWeek.Sunday|| i.DayOfWeek == DayOfWeek.Saturday)
                {
                    
                    i = i.AddDays(1);
                    continue;
                }
                i = i.AddDays(1);
                counter++;
            }
            Console.WriteLine("There are " + counter + " working days between" + i + " and " + endDate ) ;
        }
    }
}
