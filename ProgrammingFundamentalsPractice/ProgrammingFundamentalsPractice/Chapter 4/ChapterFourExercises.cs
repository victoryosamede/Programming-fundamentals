using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingFundamentalsPractice.Chapter_4
{
    public class ChapterFourExercises
    {
        public static void Exercise1()
        {
            Console.WriteLine("Enter three numbers a, b and c:");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            int sum = a + b + c;    
            Console.WriteLine(sum);

        }

        public static void Exercise2()
        {
            Console.WriteLine("Enter radius:");
            double radius = double.Parse(Console.ReadLine());
            double perimeter =(double) (2 * Math.PI * radius);
            double area = (double)(Math.PI * Math.Pow(radius, 2));
            Console.WriteLine("The area is" + " " + area + " " + "and the perimeter is " + perimeter);
        }
        public static void Exercise3()
        {
            Console.WriteLine("Enter company name, Address, phone number, fax number, website, manager's name, surname and phone number:");
            string companyName = Console.ReadLine();
            string address = Console.ReadLine();
            string phoneNumber = Console.ReadLine();
            string faxNumber = Console.ReadLine();
            string website = Console.ReadLine();
            string managerName = Console.ReadLine();
            string managerSurname = Console.ReadLine();
            string managerPhoneNumber = Console.ReadLine();
            Console.WriteLine("{0} ", companyName + " is located at " + address + " and their phone number, fax number  and website is " + phoneNumber +", " + faxNumber + ", " + website );
            Console.WriteLine("The manager is Mr " + managerName + " " + managerSurname + " and his phone number is " + managerPhoneNumber);
        }
        public static void Exercise4()
        {
            Console.WriteLine("{0:X}", 123);
            Console.WriteLine("{0, 10:#.##}", 1.234);
            Console.WriteLine("{0, 20:#.##}", -1.234);
        }
        public static void Exercise5()
        {
             Console.WriteLine("Enter two numbers: ");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            if(a < b)
            {
                for(int i = a; i <= b; i++)
                {
                    if (i % 5 == 0)
                    {
                        Console.WriteLine(i + ", ");
                    }
                }
            }
            else
            {
                for(int i = a; i >= b; i--)
                {
                    if (i % 5 == 0)
                    {
                        Console.WriteLine(i + ", ");
                    }
                }
            }
        }
        public static void Exercise6()
        {
            int a = 2020;
            int b = 1990;
            int c = Math.Max(a, b);
            Console.WriteLine(c);
        }
        public static void Exercise7()
        {
            //Console.WriteLine("Enter 5 int values:");
  
            //string a = Console.ReadLine();
            //int a2;
            //bool number = Int32.TryParse(a, out a2);
            //Console.WriteLine(number ? a2 :  "Enter a valid number");
            //int b = int.Parse(Console.ReadLine());
            //int c = int.Parse(Console.ReadLine());
            //int d = int.Parse(Console.ReadLine());
            //int e = int.Parse(Console.ReadLine());
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine("Enter 5 int values:");

                string a = Console.ReadLine();
                
                bool number = int.TryParse(a, out int a2);
                 if (number)
                 {
                    
                 }
                else
                {
                    Console.WriteLine("Enter valid number:");
                    a2 = int.Parse(Console.ReadLine()); 
                     
                }
                int sum=+ a2;
                Console.WriteLine(sum);  
                
            }
            



        }
        public static void Exercise8()
        {
            List<int> numbers = new List<int>();

            var length = 5;
            var count = 0;
            while(count < length)
            {
                Console.WriteLine("Enter five numbers");

                bool isSuccessful = int.TryParse(Console.ReadLine(), out int a);
                if (isSuccessful)
                {
                    numbers.Add(a);
                    count++;
                }
            }
            int greatest;
            if (numbers[0] > numbers[1])
            {
                greatest = numbers[0];
            }
            else
            {
                greatest = numbers[1];
            }
            for(int i = 2; i < numbers.Count; i++)
            {

                if(greatest < numbers[i])
                {
                    greatest = numbers[i];
                }
                 
            }
            Console.WriteLine("The greatest number is: " + greatest);

        }
        public static void Exercise9()
        {
            Console.WriteLine("How many numbers do you want to sum: ");
            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            for(int i = 0; i < n; i++)
            {
                Console.WriteLine("Enter a number");
                int number = int.Parse(Console.ReadLine());
                sum += number;
            }
            Console.WriteLine("The sum is: " + sum);
        }
        public static void Exercise10()
        {
            Console.WriteLine("Enter n:");
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine(i);
            }
        }
        public static void Exercise11()
        {
            int fib0 = 0;
            int fib1 = 1;
            int i = 0;
            while(i < 100)
            {
                int temp = fib0;
                fib0 = fib1;
                fib1 = fib0 + temp;
                Console.Write(fib1 + ", ");
                i++;
            }
            
        }
        public static void Exercise12()
        {
             
            double diff = 1;
            double i = 2;
            double currentSum;
            double oldSum = 1;
            
            while (diff >= 0.001)
            {
                double nextValue = (Math.Pow(-1, i) / i); 
                currentSum = oldSum + nextValue;
                
                diff = Math.Abs(currentSum - oldSum);
                oldSum = currentSum;
                i++;
            }
            Console.WriteLine(oldSum);
        }
    }
}
