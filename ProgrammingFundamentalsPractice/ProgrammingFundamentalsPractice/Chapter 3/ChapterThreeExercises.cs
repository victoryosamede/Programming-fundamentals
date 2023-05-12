    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingFundamentalsPractice.Chapter_3
{
    public class ChapterThreeExercises
    {
        public static void Exercise1()
        {
            Console.WriteLine("Enter a number: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine(a % 2 == 0 ? "It is an even number" : "It is an odd number");
        }

        public static void Exercise2()
        {
            Console.WriteLine("Enter a number");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine(b % 35 == 0 ? "Number is divisible by 5 and 7" : "Number is not divisible by 5 and 7");
        }

        public static void Exercise3()
        {
            Console.WriteLine("Enter number");
            int number = int.Parse(Console.ReadLine());
            int quotient = number / 100;
            int result = quotient % 10;
            Console.WriteLine(result == 7 ? "First digit is 7 =" + number : "Number does not start with 7");
        }

        public static void Exercise4()
        {
            Console.WriteLine("Enter a digit");
            int digit = int.Parse(Console.ReadLine());
            Console.WriteLine((digit & 8) == 0 ? "Third bit is 0" : "Third bit is 1");
            
        }

        public static void Exercise5()
        {
            Console.WriteLine("Enter value for a:");
            float a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter value for b:");
            float b = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter value for h:");
            float h = int.Parse(Console.ReadLine());
            float areaOfTrapezoid = (a + b) * h / 2;
            Console.WriteLine(areaOfTrapezoid);
        }

        public static void Exercise6()
        {
            Console.WriteLine("Enter length of rectangle: ");
            float length = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter breadth of rectangle: ");
            float breadth = int.Parse(Console.ReadLine());
            float perimeter = 2 * (length + breadth);
            float area = length * breadth;
            Console.WriteLine("perimeter is : " + perimeter + " " + "and area is : " + area);

        }

        public static void Exercise7()
        {
            Console.WriteLine("Enter weight: ");
            float weight = int.Parse(Console.ReadLine());
            float weightOnMoon = 0.17f * weight;
            Console.WriteLine("Weight on moon is: " + " " + weightOnMoon);
        }
        public static void Exercise8()
        {
            Console.WriteLine("Enter points for {x,y}");
            Console.WriteLine("Enter value for x: ");
            float x = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter value for y: ");
            float y = int.Parse(Console.ReadLine());
            float radius = 5.0f;
            Console.WriteLine((Math.Pow(x, 2) + Math.Pow(y, 2)) <= Math.Pow(radius, 2) ? "Point is within the circle" : "Point is outside circle" );
        }
        public static void Exercise9()
        {
            Console.WriteLine("Enter points for {x,y}");
            Console.WriteLine("Enter value for x: ");
            float x = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter value for y: ");
            float y = int.Parse(Console.ReadLine());
            float radius = 5.0f;
            float x1 = -1f;
            float y1 = 1f;
            float x2 = 5f;
            float y2 = 5f;
            bool inCircle = (Math.Pow(x, 2) + Math.Pow(y, 2)) <= Math.Pow(radius, 2);
            bool outOfRectangle = (Math.Pow(x, 2) + Math.Pow(y, 2) > Math.Pow(x1, 2) + Math.Pow(y1, 2) && Math.Pow(x, 2) + Math.Pow(y, 2) < Math.Pow(x2, 2) + Math.Pow(y2, 2));
            Console.WriteLine(inCircle && outOfRectangle ? "Point is within the circle and outside the rectangle" : "Point is somewhere else");
        }

        public static void Exercise10()
        {
            Console.WriteLine("Enter a 4 digit number: ");
            int num = int.Parse(Console.ReadLine());
            if ((num / 1000) % 10 > 0 && (num / 1000) % 10 < 10)
            {
                Console.WriteLine("Please Enter a 4 digit number: ");
                num = int.Parse(Console.ReadLine());
            }
             
                int a = num % 10;
                int b = (num / 10) % 10;
                int c = (num / 100) % 10;
                int d = (num / 1000) % 10;
                int add = a + b + c + d;
                Console.WriteLine(add);
            
        }
        public static void Exercise11()
        {
            Console.WriteLine("Enter value for n: ");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter value for p: ");
            int p = int.Parse(Console.ReadLine());
            int i = 1;
            int mask = i << p;
            Console.WriteLine((n & mask) != 0 ? 1 : 0);
        }
        public static void Exercise12()
        {
            Console.WriteLine("Enter value for v: ");
            int v = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter value for p: ");
            int p = int.Parse(Console.ReadLine());
            int i = 1;
            int mask = i << p;
            Console.WriteLine((v & mask) == 1 ? true: false);
        }
        public static void Exercise13()
        {
            Console.WriteLine("Enter value for v: ");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter value for p: ");
            int p = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter 0 or 1 for v:");
            int v = int.Parse(Console.ReadLine());
            int mask = 1 << p;
            n = n & ~mask; //resets position p to 0
            n = n | (v << p);
            Console.WriteLine(n);
            
             
        }
        public static void Exercise14()
        {
            
            
            for (int j = 2; j < 100; j++)
            {
                int root = (int)Math.Sqrt(j) + 1;
                if(j == 2)
                {
                    Console.WriteLine(j);
                }
                for (int i = 2; i <= root; i++)
                {
                    if (j % i == 0)
                    {
                         
                        break;
                    }
                    else if (i == root)
                    {
                        Console.WriteLine(j);
                    }


                }

            }

            
        }
        public static void Exercise15()
        {
            Console.WriteLine("Enter number:");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter first bit");
            int firstDigit = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter second bit");
            int secondDigit = int.Parse(Console.ReadLine());
            int firstBit = (num >> firstDigit) & 1;
            int secondBit = (num >> secondDigit) & 1;   
            num = num & (~(1 << secondDigit)) | (firstBit << secondDigit);
            num = num & (~(1 << firstDigit)) | (secondBit << firstDigit);
            Console.WriteLine(num);
            



        }
        //public static void Exercise16()
        //{
        //    int exponent = -1;
        //    string myString = string.Format($"x^{exponent}");
        //    Console.WriteLine(myString);
        //    8c1fce0b8d8d0777f33be68a38b0e393;
        //}
    }
}
