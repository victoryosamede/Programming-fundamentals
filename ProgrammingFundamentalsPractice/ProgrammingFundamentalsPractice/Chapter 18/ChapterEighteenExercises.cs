using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingFundamentalsPractice.Chapter_18
{
    public class ChapterEighteenExercises
    {
        public static void Exercise1()
        {
            int[] array = { 3, 4, 4, 2, 3, 3, 4, 3, 2 };
            Dictionary<int, int> count = new Dictionary<int, int>();
            
            foreach(int num in array)
            {
                if(count.ContainsKey(num))
                {
                    count[num]++;
                }
                else
                {
                    count[num] = 1;
                }
            }
            foreach(var key in count)
            {
                Console.WriteLine($"{key.Key} -> {key.Value} times");
            }
        }
        
        public static void Exercise2()
        {
            int[] array = { 4, 2, 2, 5, 2, 3, 2, 3, 1, 5, 2, 6, 6, 6 };
            Dictionary<int, int> count = new Dictionary<int, int>();
           
            foreach(int num in array)
            {
                if(count.ContainsKey(num))
                {
                    count[num]++;
                }

                else
                {
                    count[num] = 1;
                }
            }
            List<int> list = new List<int>();
            foreach (var kvp in count)
            {
                if(kvp.Value % 2 == 0)
                {
                    Console.WriteLine(string.Join(", ", Enumerable.Repeat(kvp.Key, kvp.Value)));
                }
                 
            }
            
        }
    }
}
