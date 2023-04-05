using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingFundamentalsPractice.Chapter_16
{
    public class ChapterSixteenExercises
    {
        public static void Exercise1()
        {
            List<double> list = new List<double>();
            double sum = 0;
            double average = 0;
            while (true)
            {
                Console.WriteLine("Enter numbers: ");
                string num = (Console.ReadLine());
                if(num != string.Empty)
                {
                    double number = double.Parse(num);
                    list.Add(number);
                    sum = sum + number;
                }
                else
                {
                    break;
                }
               
                
            }
            Console.WriteLine(sum);
            average = sum/list.Count;
            Console.WriteLine(average);
        }
        public static void Exercise2()
        {
            Console.WriteLine("Enter n:");
            int n = int.Parse(Console.ReadLine());
            Stack<int> stack = new Stack<int>();
            while(stack.Count < n)
            {
                Console.WriteLine("Enter n integers: ");
                int nInteger = int.Parse(Console.ReadLine());      
                stack.Push(nInteger);
            }
            while(stack.Count > 0)
            {
                int integer = stack.Pop();
                Console.WriteLine(integer);
            }
        }
        public static void Exercise3()
        {
            List<int> list = new List<int>();
            
            while (true)
            {
                Console.WriteLine("Enter numbers: ");
                string num = (Console.ReadLine());
                if (num != string.Empty)
                {
                    int number = int.Parse(num);
                    list.Add(number);
                   
                }
                else
                {
                    break;
                }
                

            }
            list.Sort();
        }
    }
}
