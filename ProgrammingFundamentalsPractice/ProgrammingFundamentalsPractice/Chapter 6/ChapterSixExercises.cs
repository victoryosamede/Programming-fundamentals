using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace ProgrammingFundamentalsPractice.Chapter_6
{
    public class ChapterSixExercises
    {
        public static void Exercise1()
        {
            Console.Write("Enter n: ");
            int n = int.Parse(Console.ReadLine());
            for(int i = 1; i <= n; i++) 
            {
                Console.Write(i + ", ");
            }
        }
        public static void Exercise2()
        {
            Console.Write("Enter n: ");
            int n = int.Parse(Console.ReadLine());
            for(int i = 1; i <= n; i++)
            {
                if(i % 21 == 0)
                {
                    continue;
                }
                Console.Write(i + ", ");
            }
        }
        public static void Exercise3()
        {
            Console.Write("Enter n: ");
            int n = int.Parse(Console.ReadLine());
            int smallest = int.MaxValue;
            int largest = int.MinValue;
            for (int i = 1; i <= n; i++)
            {
                Console.Write("Enter number: ");
                int number = int.Parse(Console.ReadLine());
                
               if(largest < number)
                {
                    largest = number;
                }
                
                if(smallest > number)
                {
                    smallest = number;
                    continue;
                }
                 
                
            }
            Console.Write(smallest + " is the smallest number " + "and " + largest + " is the largest number");
        }
        public static void Exercise4()
        {
            for(int i = 1; i <= 4; i++ )
            {
                for(int j = 2; j <= 14; j++)
                {
                    if (j == 11)
                    {
                        continue;
                    }
                    switch (i)
                    {
                        case 1: Console.Write("club-");
                            break;
                        case 2:Console.Write("diamond-");
                            break;
                        case 3: Console.Write("heart-");
                            break;
                        case 4: Console.Write("spades-");
                            break;

                    }
                    switch(j)
                    {
                        case 2: Console.WriteLine("2");
                            break;
                        case 3: Console.WriteLine("3");
                            break;
                        case 4: Console.WriteLine("4");
                            break;
                        case 5: Console.WriteLine("5");
                            break;
                        case 6: Console.WriteLine("6");
                            break;
                        case 7: Console.WriteLine("7");
                            break;
                        case 8: Console.WriteLine("8");
                            break;
                        case 9: Console.WriteLine("9");
                            break;
                        case 10: Console.WriteLine("10");
                            break;
                        case 11: Console.WriteLine("J");
                            break;
                        case 12: Console.WriteLine("Q");
                            break;
                        case 13: Console.WriteLine("K");
                            break;
                        case 14: Console.WriteLine("A");
                            break;
                    }
                }
            }
        }
        public static void Exercise5()
        {
            int fib0 = 0;
            int fib1 = 1;
            int i = 0;
            int sum = 0;
            Console.Write("Enter n: ");
            int n = int.Parse(Console.ReadLine());
            while (i <= n)
            {
                int temp = fib0;
                fib0 = fib1;
                fib1 = fib0 + temp;
                sum += fib1;
                Console.Write(sum);
                i++;
             
            }
            
        }
        public static void Exercise6()
        {
            Console.Write("Enter number for K: ");
            int k = int.Parse(Console.ReadLine());
            Console.Write("Enter number for N: ");
            int n = int.Parse(Console.ReadLine());
            int factorialK = 1;
            int factorialN = 1;
            if(k > 1 && k< n)
            {
                for(int i = 1; i <= k; i++)
                {
                    
                    factorialK *= i;
                }

            }
            if(n > k && n > 1)
            {
                for (int i = 1; i <= n; i++)
                {

                    factorialN *= i;
                }
            }
            int division = factorialN / factorialK;
            Console.WriteLine("N!/K! is " + division);
        }
        public static void Exercise7()
        {
            Console.Write("Enter number for K: ");
            int k = int.Parse(Console.ReadLine());
            Console.Write("Enter number for N: ");
            int n = int.Parse(Console.ReadLine());
            int diff = n - k;
            int factorialK = 1;
            int factorialN = 1;
            int factorialD = 1;
            if (k > 1 && k < n)
            {
                for (int i = 1; i <= k; i++)
                {

                    factorialK *= i;
                }

            }
            if (n > k && n > 1)
            {
                for (int i = 1; i <= n; i++)
                {

                    factorialN *= i;
                }
            }
            for(int i =1; i <= diff; i++)
            {
                factorialD *= i;
            }
            int result = (factorialN * factorialK)/factorialD;
            Console.WriteLine("N!*K!/(N-K)! is " + result);
        }
        public static void Exercise8()
        {
            Console.Write("Enter value for n");
            int n = int.Parse(Console.ReadLine());
            int twoN = 2 * n;
            int nplusOne = n + 1;
            int twoNFactorial = 1;
            int nplusOneFactorial = 1;
            int factorialN = 1;

            for (int i = 1; i <= twoN; i++)
            {

                 twoNFactorial *= i;
            }
            for (int i = 1; i <= nplusOne; i++)
            {

                 nplusOneFactorial *= i;
            }
            for (int i = 1; i <= n; i++)
            {

                factorialN *= i;
            }
            int result = twoNFactorial/(nplusOneFactorial * factorialN);
            Console.WriteLine(result);
        }
        public static void Exercise9()
        {
            Console.Write("Enter value for n and x: ");
            int n = int.Parse(Console.ReadLine());
            int x = int.Parse(Console.ReadLine());
            int nFactorial = 1;
            double sSum = 1;
            double xPower = 1;
            
            for(int i = 1; i <= n; i++ )
            {
                nFactorial *= i;
                xPower = Math.Pow(x, i);
                sSum += (double)nFactorial / xPower; 

            }
            Console.WriteLine(sSum);
        }
        public static void Exercise10()
        {
            Console.Write("Enter N: ");
            int n = int.Parse(Console.ReadLine());
            if(n < 20)
            {
                for (int i = 1; i <= n; i++)
                {
                    int inner = i + n - 1;
                    for(int j = i; j <= inner; j++ )
                    {
                        Console.Write(j);
                        
                    }
                    Console.WriteLine();
                }
            }
        }
        public static void Exercise11()
        {
            Console.Write("Enter number: ");
            int num = int.Parse(Console.ReadLine());
            int nFactorial = 1;
            for (int i = 1; i <= num; i++)
            {
                nFactorial *= i;
            }
             
            int countZero = 0;

            int count = 0;
            while (countZero == 0)
            {
                countZero = nFactorial % 10;
                int newNum = nFactorial / 10;
                nFactorial = newNum;
                 
                if(countZero== 0)
                {
                    count++;
                }
                 
            }
               Console.WriteLine("Number of zeroes at the end is: " + count);

        }
        public static void Exercise12()
        {
            Console.Write("Enter number to convert: ");
            int num = int.Parse(Console.ReadLine());
            int divide = 1;
            string result = string.Empty;
            while(divide != 0)
            {
                divide = num / 2;
                int value = num % 2;
                string val = value.ToString();
                result = result + val;
                num = divide;
                
            }
            Console.WriteLine(result.Reverse().ToArray());
        }
        public static void Exercise13()
        {
            Console.Write("Enter number in base 2: ");
            string binary = Console.ReadLine();
            int length = binary.Length - 1;
            char[] chars = binary.ToCharArray();
            int sum = 0;
            for(int i = length, j = 0; i >= 0; i--, j++)
            {
                int bitDigit = chars[j] - 48;  

                sum += bitDigit*(int)Math.Pow(2, i);
            }
            Console.WriteLine(sum);
        }
        public static void Exercise14()
        {
            Console.Write("Enter number to convert: ");
            int num = int.Parse(Console.ReadLine());
            int divide = 1;
            string result = string.Empty;
            while (divide != 0)
            {
                divide = num / 16;
                int value = num % 16;
                string val = value.ToString();
                if (value > 9)
                {
                    switch(value)
                    {
                        case 10: val = "A";
                            break;
                        case 11: val = "B";
                            break;
                        case 12: val = "C";
                            break;
                        case 13: val = "D";
                            break;
                        case 14: val = "E";
                            break;
                        case 15: val = "F";
                            break;
                            default: break;
                        
                    }
                }
                
                result = result + val;
                num = divide;

            }
            Console.WriteLine(result.Reverse().ToArray());
        }
        public static void Exercise15()
        {
            Console.Write("Enter hexadecimal number: ");
            string binary = Console.ReadLine().ToUpper();
            int length = binary.Length - 1;
            char[] chars = binary.ToCharArray();
            int sum = 0;

            


            for (int i = length, j = 0; i >= 0; i--, j++)
            {
                switch (chars[j])
                {
                    case '0':
                        break;
                    case '1': 
                        sum += (int)Math.Pow(16, i);
                        break;
                    case '2':
                        sum += 2 * (int)Math.Pow(16, i); 
                        break;
                    case '3':
                        sum += 3 * (int)Math.Pow(16, i);
                        break;
                    case '4':
                        sum += 4 * (int)Math.Pow(16, i);
                        break;
                    case '5':
                        sum += 5 * (int)Math.Pow(16, i);
                        break;
                    case '6':
                        sum += 6 * (int)Math.Pow(16, i);
                        break;
                    case '7':
                        sum += 7 * (int)Math.Pow(16, i);
                        break;
                    case '8':
                        sum += 8 * (int)Math.Pow(16, i);
                        break;
                    case '9':
                        sum += 9 * (int)Math.Pow(16, i);
                        break;
                    case 'A':
                        sum += 10*(int)Math.Pow(16, i);
                        break;
                    case 'B':
                        sum += 11 * (int)Math.Pow(16, i);
                        break;
                    case 'C':
                        sum += 12 * (int)Math.Pow(16, i);
                        break;
                    case 'D':
                        sum += 13 * (int)Math.Pow(16, i);
                        break;
                    case 'E':
                        sum += 14 * (int)Math.Pow(16, i);
                        break;
                    case 'F':
                        sum += 15 * (int)Math.Pow(16, i);
                        break;
                }

                 
            }
            Console.WriteLine(sum);
        }
        public static void Exercise16()
        {
            Console.Write("Enter n: ");
            int n = int.Parse(Console.ReadLine());
            int[] random = new int [n];
             

            var randGen = new Random();
           
            for(int i =0; i < n; i++)
            {
                random[i] = i + 1;
            }
            for (int i = 0; i < n; i++)
            {
                
                
                var randomNumbers = randGen.Next(0, n);
                var randomNumbersTwo = randGen.Next(0, n);
                if (i % 2 == 0)
                {


                    int temp = random[randomNumbers];
                    random[randomNumbers] = random[randomNumbersTwo];
                    random[randomNumbersTwo] = temp;

                }
                
                Console.Write(random[i] + ", ");
            }
        }
        public static void Exercise17()
        {
            Console.WriteLine("Enter value for a: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter value for b: ");
            int b = int.Parse(Console.ReadLine());
            int temp;
            while(b != 0)
            {
                temp = b;
                b = a % b;
                a = temp;

            }
            Console.WriteLine(a);
        }
    }
}
