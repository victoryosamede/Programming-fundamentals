using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingFundamentalsPractice.Chapter_19
{
    public class ChapterNineteenExercises
    {
        public static void SubSetOfASet()
        {
            string[] words = { "ocean", "beer", "money", "happiness" };
            Queue<HashSet<string>> subsetQueue = new Queue<HashSet<string>>();
            HashSet<string> emptySet = new HashSet<string>();
            subsetQueue.Enqueue(emptySet);

            while(subsetQueue.Count > 0)
            {
                HashSet<string> subset = subsetQueue.Dequeue();
                Console.Write("{");
                foreach (string word in subset )
                {
                    Console.Write(word + " ");
                }
                Console.WriteLine("}");

                foreach(string element in words)
                {
                    if(!subset.Contains(element))
                    {
                        HashSet<string> newSubset = new HashSet<string>();
                        newSubset.UnionWith(subset);
                        newSubset.Add(element);
                        subsetQueue.Enqueue(newSubset);
                    }
                }
            }
        }
        public static void Exercise1()
        {
            Dictionary<string, List<string>> multipleValues = new Dictionary<string, List<string>>();
            List<string> otherNames = new List<string>();
            otherNames.Add("Osamede");
            otherNames.Add("Uhunmwangho");
            multipleValues.Add("Victory", otherNames);
            foreach(var key in multipleValues)
            {
                Console.Write($"{key.Key} ");
                foreach(var name in otherNames)
                {
                    Console.Write(name + " ");
                }
            }
        }
        public static void Exercise2()
        {
              List<int> numbers = new List<int>();
            for (int i = 12; i >= 2; i -= 2)
            {
                numbers.Add(i);
            }

            SortedSet<int> ints = new SortedSet<int>(numbers);

            ints.First();
            ints.Add(4);

            //ints.Add(numbers);
            //var first = numbers.First();

            //foreach (var integer in ints)
            //{
            //    foreach (var number in numbers)
            //    {
            //        Console.Write(number + ",");
            //    }
            //}
            //Console.WriteLine("");
            //Console.WriteLine($"The first element is {first}");
        }
    }


    class Parent
    {
        protected void MethodA()
        {
        }

        protected virtual void MethodB() { }
    }

    class Child : Parent
    {
        protected void MethodC()
        {
            MethodA();
        }
        protected override void MethodB()
        {
            base.MethodB();
        }
    }
}
