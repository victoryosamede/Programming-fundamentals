using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingFundamentalsPractice.Chapter_8
{
    public class ChapterEightExercises
    {
        public static void Exercise1()
        {
            Console.Write("Enter n");
            int n = int.Parse(Console.ReadLine());
            int r = 0;

            var length = GetNumberOfElements(n);
            int[] bits = new int[length];
            int i = 0;
                while (n > 0)
                {
                    
                    r = n % 2;
                    n = n / 2;
                    bits[i] = r;
                i++;
                
                }
            
            for(i = length - 1; i >= 0; i--)
            {
                Console.Write(bits[i] + ", ");
            }
        }

        static int GetNumberOfElements(int n)
        {
            int r = 0;
            int num = 0;
            while (n > 0)
            {
                r = n % 2;
                n = n / 2;
                num++;
            }

            return num;
        }
        
        public static void Exercise2()
        {

            ConvertToDecimal(1010);

             


        }
        
        static int ConvertToDecimal(int n)
        {
            Console.Write("Enter n");
            int num = int.Parse(Console.ReadLine());
            int length = num;
            int[] array = new int[length];
            for (int i = 0; i < length; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }
            int sum = 0;
            for(int i = 0; i < length; i++)
            {
                sum += array[i] * (int)Math.Pow(2, i);
            }
            return sum;
        }
    }
}
