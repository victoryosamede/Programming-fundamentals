using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
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
        public static void Exercise4()
        {
            int[] array = { 1, 1, 2, 3, 2, 2, 2, 1 };
            int start = 0;
            int len = 1;
            int bestStart = 0;
            int bestLen = 0;
            int end = 0;
            int j;
            for (int i = 0; i < array.Length; i++)
            {
                if (i > 0)
                {
                    if (array[i - 1] == array[i])
                    {
                        len++;
                         
                    }
                    else if (array[i - 1] != array[i])
                    {

                        if (len > bestLen)
                        {
                            bestStart = start;
                            
                            bestLen = len;
                            len = 1;
                            end = i - 1;

                        }
                        start = i;

                    }
                }
                
                
            }
            for ( j = bestStart; j <= end; j++)
            {
                Console.Write(array[j] + " ");
            }
        }
        public static void Exercise5()
        {
            int[] array = { 3, 2, 3, 4, 2, 2, 4 };
            int start = 0;
            int len = 1;
            int bestStart = 0;
            int bestLen = 0;
            int end = 0;
            int j;
            for (int i = 0; i < array.Length; i++)
            {
                if (i > 0)
                {
                    if (array[i - 1] == array[i] - 1)
                    {
                        len++;

                    }
                    else if (array[i - 1] != array[i] - 1)
                    {

                        if (len > bestLen)
                        {
                            bestStart = start;

                            bestLen = len;
                            len = 1;
                            end = i - 1;

                        }
                        start = i;

                    }
                }


            }
            for (j = bestStart; j <= end; j++)
            {
                Console.Write(array[j] + " ");
            }
            
        }
        public static void Exercise6()
        {
            int[] array = {9, 6, 2, 7, 4, 7, 6, 5, 8, 4 };
            int prev;
            int current;
            int next;
            for(int i = 0; i < array.Length; i++)
            {
                for (int j = i + 1; j < array.Length; i++)
                {
                    prev = array[i];
                    current = array[j];
                    
                }
            }
        }
        public static void Exercise7()
        {
            int k;
            int n;
            Console.WriteLine("Enter n");
            Console.WriteLine("Enter k");
            n = int.Parse(Console.ReadLine());
            k = int.Parse(Console.ReadLine());
            if (k > n)
            {
                for (int i = 0; k > n; i++)
                {
                    Console.WriteLine("K has to be less than N");
                    Console.WriteLine("Enter n");
                    Console.WriteLine("Enter k");
                    n = int.Parse(Console.ReadLine());
                    k = int.Parse(Console.ReadLine());
                }

            }
            int bestSum = 0;
            int[] array = { 5, 3, 2, 4, 7 };
            int m = k;
            
            for(int i = 0; i < k   && k <= array.Length; i++)
            {
                k++;
                int sum = array[i];
                
                for(int j = i + 1; j < m && j < array.Length ; j++)
                {
                    
                    
                        sum += array[j];
                    
                }
                m++;
                if(bestSum < sum)
                {
                    bestSum= sum;
                }
            }
            Console.WriteLine("The maximal sum is: " + " " + bestSum);

        }
        public static void Exercise8()
        {
            int[] arr = { 56, 1 , 99, 67, 89 };
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] > arr[j])
                    {
                        int temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
            }
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
        }
        public static void Exercise9()
        {
           
            int m = 2;
            int[] array = { 2, 3, -6, -1, 2, -1, 6, 4, -8, 8 };
            int bestSum = 0;
            int bestStart = 0;
            int end = 0;
            int start = 0;
            int j = 0;
            int prev = m;
            while (m < array.Length)
            {
                int k = 1;
                for (int i = 0; i < k && k < array.Length; i++)
                {
                    k++;
                    int sum = array[i];
                    start = i;
                   
                    for (j = i + 1; j < m && j < array.Length; j++)
                    {


                        sum += array[j];

                    }
                    m++;
                    if (bestSum < sum)
                    {
                       
                        bestSum = sum;
                        bestStart = start;
                        end = j - 1;
                    }
                }

                m = prev;
                m++;
                prev = m;
                 
            }
            for(int i = bestStart; i <= end; i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.Write("->" + bestSum);
        }
        public static void Exercise10()
        {
            int[] arr = { 4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3 };
            int len = 1;
            int bestLen = 0;
            int bestStart = 0;
            int start = 0;
            int end = 0;
            int num = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] > arr[j])
                    {
                        int temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
            }
            for (int i = 0; i < arr.Length; i++)
            {
                start = i;
                for(int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        len++;

                    }
                    else if (arr[i] != arr[j])
                    {
                        i = j - 1;
                        if (len > bestLen)
                        {
                            bestStart = start;

                            bestLen = len;
                            
                            end = j;
                            num = arr[j - 1];
                            
                        }
                        len = 1;
                        break;

                    }
                    
                     
                }


            }
            Console.WriteLine("The number {0}, occured {1} times", num, bestLen);
        }
        public static void Exercise11()
        {

            int m = 2;
            int[] array = {4, 3, 1, 4, 2, 5, 8 };
            int bestSum = 0;
            int bestStart = 0;
            int end = 0;
            int start = 0;
            int j = 0;
            int prev = m;
            int len = 1;
            while (m < array.Length)
            {
                int k = 1;
                for (int i = 0; i < k && k < array.Length; i++)
                {
                    k++;
                    int sum = array[i];
                    start = i;

                    for (j = i + 1; j < m && j < array.Length; j++)
                    {


                        sum += array[j];

                    }
                    m++;
                    if (sum == 11)
                    {

                        bestSum = sum;
                        bestStart = start;
                        end = j - 1;
                        len = m;
                    }
                }

                m = prev;
                m++;
                prev = m;

            }
            Console.Write("S = 11-> {");
            for (int i = bestStart; i <= end; i++)
            {
                Console.Write(array[i] + ",");
            }
            Console.Write("}");
             
        }
        public static void Exercise12()
        {
            Console.Write("Enter n: ");
            int n = int.Parse(Console.ReadLine());
            int[,] matrix = new int[n, n];
            //for(int col = 0, j = 1; col < n; col ++)
            //{
            //    for(int row = 0; row < n; row ++, j++)
            //    {
            //        matrix[row, col] = j;
            //    }
            //}
            //for (int row = 0; row < matrix.GetLength(0); row++)
            //{
            //    for (int col = 0; col < matrix.GetLength(1); col++)
            //    {
            //        Console.Write(" " + matrix[row, col]);
            //    }
            //    Console.WriteLine();
            //}

            //for (int col = 0, j = 1, row = 0; col < n; col++)
            //{

            //    if (row == 0)
            //    {
            //        for(row = 0; row < n; row++, j++)
            //        {
            //            matrix[row, col] = j;
            //        }
            //    }
            //    else if(row == n)
            //    {
            //        for(row = n - 1; row >= 0; row--, j++)
            //        {
            //            matrix[row, col] = j;
            //        }
            //        row++;
            //    }
            //}
            //for (int row = 0; row < matrix.GetLength(0); row++)
            //{
            //    for (int col = 0; col < matrix.GetLength(1); col++)
            //    {
            //        Console.Write(" " + matrix[row, col]);
            //    }
            //    Console.WriteLine();
            //}


            //for(int row = n - 1, i = 1, j = 1; row >= 0; row--, i++)
            //{
            //    int temp = row;

            //    for (int col = 0; col < n && col < i ; col++, j++,temp++)
            //    {
            //        matrix[temp, col] = j;
            //    }
            //    if(row == 0)
            //    {
            //        for(int col = 1, k = n; col < n; col ++)
            //        {
            //            temp = col;
            //            {
            //                for(row = 0; row < k && temp < k; row++, j++, temp++)
            //                {
            //                    matrix[row, temp] = j;
            //                }
            //            }
            //        }
            //        break;
            //    }


            //}
            //for (int row = 0; row < matrix.GetLength(0); row++)
            //{
            //    for (int col = 0; col < matrix.GetLength(1); col++)
            //    {
            //        Console.Write(" " + matrix[row, col]);
            //    }
            //    Console.WriteLine();
            //}
            int positionX = n - n;
            int positionY = n - n;
            int direction = 0;
            int stepsCount = 1;
            int stepPosition = 0;
            int stepChange = 0;
            for (int i = 1; i <= n * n; i++)
            {

                matrix[positionY, positionX] = i;
            }
            if (stepPosition < stepsCount)
            {
                stepPosition++;
            }
            else
            {
                stepPosition = 1;
                if (stepChange == 1)
                {
                    stepsCount++;
                }
                stepChange = (stepChange + 1) % 2;
                direction = (direction + 1) % 3;
            }
            switch (direction)
            {
                case 0:
                    positionY++;
                    break;
                case 1:
                    positionX--;
                    break;
                case 2:
                    positionY--;
                    break;
                case 3:
                    positionX++;
                    break;
            }
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write(" " + matrix[row, col]);
                }
                Console.WriteLine();


            }
        }
    }
}






