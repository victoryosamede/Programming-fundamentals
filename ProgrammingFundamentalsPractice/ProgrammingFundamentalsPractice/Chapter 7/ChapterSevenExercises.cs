using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingFundamentalsPractice.Chapter_7
{
    public class ChapterSevenExercises
    {
        public static void Exercise1()
        {
            int[] elements = new int[20];
            int length = elements.Length;
            for(int i = 0; i < length; i++)
            {
                elements[i] = i * 5;
                Console.Write(elements[i] + ", ");
            }
        }
        public static void Exercise2()
        {
            Console.Write("Enter length of first array: ");
            int n1 = int.Parse(Console.ReadLine());
            Console.Write("Enter length for second array: ");
            int n2 = int.Parse(Console.ReadLine());
            int[] firstArray = new int[n1];
            for(int i = 0; i < n1; i++)
            {
                Console.Write("Enter elements for first array: ");
                firstArray[i] = int.Parse(Console.ReadLine());
                 
            }
            int[] secondArray = new int[n2];
            for (int i = 0; i < n2; i++)
            {
                Console.Write("Enter elements for second array: ");
                secondArray[i] = int.Parse(Console.ReadLine());
                 
            }
            if(n1 == n2)
            {
                for(int i = 0; i < n1; i++)
                {
                    if (firstArray[i] == secondArray[i])
                    {
                        continue;
                    }
                }
                Console.WriteLine("Both arrays are equal");
            }
            else
            {
                Console.WriteLine("Arrays are not equal");
            }
        }
        public static void Exercise3()
        {
            char[] chars = { 'a', 'b', 'c', 'd', 'f' };
            char[] chars2 = { 'a', 'e', 'z', 'h', 'i', 't', 'w' };
            int greatest = chars.Length;
            if(chars2.Length > chars.Length)
            {
                greatest = chars2.Length;
            }
            for(int i = 0; i < chars.Length; i++)
            {
                if (chars[i] < chars2[i])
                {
                    Console.WriteLine(chars[i] + " comes first");
                }
                else if (chars[i] > chars2[i])
                {
                    Console.WriteLine(chars2[i] + " comes first");
                }
                else if (chars[i] == chars2[i])
                {
                    int count = 0;
                    count++;
                    if(count == chars.Length)
                    {
                        Console.WriteLine("chars is smaller");
                    }
                }
                else
                {
                    Console.WriteLine("Both arrays are equal");
                }
            }
        }
    }
}
