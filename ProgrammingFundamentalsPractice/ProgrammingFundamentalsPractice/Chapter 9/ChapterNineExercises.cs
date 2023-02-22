using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingFundamentalsPractice.Chapter_9
{
    public class ChapterNineExercises
    {
        public static void Exercise1()
        {
            PrintName("Victory!");
             
        }
        public static void PrintName(string name)
        {
            Console.WriteLine("Hello " + name);
        }
        public static void Exercise2()
        {
            Console.Write("Enter three values");
            var a = int.Parse(Console.ReadLine());
            var b = int.Parse(Console.ReadLine());
            var c = int.Parse(Console.ReadLine());
            GetMax(GetMax(a, b),c);
             
        }
        public static int GetMax(int a, int b)
        {
            int max = a;
            if(a < b)
            {
                int temp = max;
                a = temp;
                max = b;
            }
            Console.WriteLine(max);
            return max;

        }
    }
}
