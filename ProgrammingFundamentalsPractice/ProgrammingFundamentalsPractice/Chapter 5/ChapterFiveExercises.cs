using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace ProgrammingFundamentalsPractice.Chapter_5
{
    public class ChapterFiveExercises
    {
        public static void Exercise1()
        {
            Console.WriteLine("Enter two numbers");
            int firstNumber = int.Parse(Console.ReadLine());
            int seconNumber = int.Parse(Console.ReadLine());

            int biggestNumber = firstNumber;
            if(seconNumber > biggestNumber) 
            {
                biggestNumber= seconNumber;
            }
            Console.WriteLine("The greatest number is: " + biggestNumber);
             
        }
        public static void Exercise2()
        {
            Console.WriteLine("Enter 3 numbers");
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());
            int negativeNumbersCount = 0;
            if(num1 < 0)
            {
                negativeNumbersCount++;
            }
            else if(num1 == 0)
            {
                Console.WriteLine("The product is 0.");
            }
            if (num2 < 0)
            {
                negativeNumbersCount++;
            }
            if (num3 < 0)
            {
                negativeNumbersCount++;
            }
            if(negativeNumbersCount % 2 == 0)
            {
               Console.WriteLine("The product is  '+'");
            }
            else
            {
                Console.WriteLine("The product is '-");
            }
        }
        public static void Exercise3()
        {
            Console.WriteLine("Enter 3 numbers");
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());
            int largestNumber = num1;
            if(largestNumber < num2)
            {
                largestNumber = num2;
            }
            if(largestNumber < num3) 
            {
                largestNumber= num3;
            }
            Console.WriteLine("The largest number is: "+ largestNumber);

        }
        public static void Exercise4()
        {
            Console.WriteLine("Enter 3 numbers");
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse (Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());
            int temp;
            for (int i = 1; i <= 2; i++)
            {
                if (num1 < num2)
                {
                    temp = num1;
                    num1 = num2;
                    num2 = temp;
                }
                if (num2 < num3)
                {
                    temp = num2;
                    num2 = num3;
                    num3 = temp;
                }
            }
            Console.WriteLine(num1 + " " + num2 + " " + num3);
        }
        public static void Exercise5()
        {
            Console.WriteLine("Enter a digit");
            int number = int.Parse(Console.ReadLine());
            switch(number)
            {
                case 0: Console.WriteLine("Zero");
                    break;
                case 1: Console.WriteLine("One");
                    break;
                case 2: Console.WriteLine("Two");
                    break;
                case 3: Console.WriteLine("Three");
                    break;
                case 4: Console.WriteLine("Four");
                    break;
                case 5: Console.WriteLine("Five");
                    break;
                case 6: Console.WriteLine("Six");
                    break; 
                case 7: Console.WriteLine("Seven");
                    break;
                case 8: Console.WriteLine("Eight");
                    break;
                case 9: Console.WriteLine("Nine");
                    break;
                default: Console.WriteLine("Number is out of range");
                    break;
            }
        }
        public static void Exercise6()
        {
            Console.WriteLine("Input a: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Input b: ");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Input c");
            int c = int.Parse(Console.ReadLine());
            int discriminant = (int)Math.Pow(b, 2) - 4 * a * c;
            if(discriminant == 0)
            {
                int x1 = -b / 2 * a;
                int x2 = x1;
                Console.WriteLine("The roots are the same " +  x1+ ", " + x2);
            }
            if(discriminant > 0)
            {
                int x1 = -b + (int)Math.Sqrt(discriminant)/ 2 * a;
                int x2 = -b - (int)Math.Sqrt(discriminant) / 2 * a;
                Console.WriteLine("The roots are: " + x1 + " and " + x2);
            }
            if(discriminant < 0)
            {
                Console.WriteLine("The quadratic equation has no real roots");
            }
        }
        public static void Exercise7()
        {
            Console.WriteLine("Enter five numbers: ");
            int a1 = int.Parse(Console.ReadLine());
            int b2 = int.Parse(Console.ReadLine());
            int c3 = int.Parse(Console.ReadLine());
            int d4 = int.Parse(Console.ReadLine());
            int e5 = int.Parse(Console.ReadLine());
            int greatest = a1;
            if(greatest < b2)
            {
                greatest = b2;
            }
            if(greatest < c3) 
            {
                greatest = c3;
            }
            if(greatest < d4)
            {
                greatest = d4;
            }
            if(greatest < e5)
            {
                greatest = e5;
            }
            Console.WriteLine("The greatest number: " + greatest);
        }
        public static void Exercise8()
        {
            Console.WriteLine("Enter 0 for int, 1 for double and 2 for string");
            int inputType = int.Parse(Console.ReadLine());
            switch(inputType)
            {
                case 0: Console.WriteLine("Enter integer number");
                    bool isValue = int.TryParse(Console.ReadLine(), out int a);
                    if(isValue)
                    {
                        Console.WriteLine(++a);
                    }
                    break;
                case 1:
                    Console.WriteLine("Enter double number");
                    bool doubleType = double.TryParse(Console.ReadLine(), out double b);
                    if (doubleType)
                    {
                        Console.WriteLine(++b);
                    };
                    break;
                case 2:
                    Console.WriteLine("Enter string");
                    string stringType = (Console.ReadLine());
                    Console.WriteLine(stringType + "*");
                    break;
            }
            
        }
        public static void Exercise9()
        {
            int sum = 5;
            int[] setOfNumbers = new int[] { 5, 3, -3, 2, -1 };
            int length = setOfNumbers.Length - 1;
             
            //foreach(int number in setOfNumbers)
            //{
            //    Console.Write(number+ ", ");
                
            //}
            //Console.WriteLine(" ");
            //for(int i = 0; i <= length; i++)
            //{
                 
            //    for(int j = 0; j <= length; j++)
            //    {
            //        if(j == i)
            //        {
            //            continue;
            //        }
            //        Console.Write(setOfNumbers[j] + ", ");
            //    }
            //    Console.WriteLine(" ");

            //}
            for (int i = 0; i <= length; i++)
            {
                if (setOfNumbers[i] == sum)
                {
                    Console.WriteLine($"({setOfNumbers[i]})");
                }
                for (int j = 1; j <= length; j++)
                {
                    if (setOfNumbers[i] + setOfNumbers[j] == sum)
                    {
                        Console.WriteLine($"({setOfNumbers[i]}, {setOfNumbers[j]})");
                    }
                    for (int k = 2; k<= length; k++)
                    {
                        if (setOfNumbers[i] + setOfNumbers[j] + setOfNumbers[k] == sum)
                        {
                            Console.WriteLine($"({setOfNumbers[i]}, {setOfNumbers[j]}, {setOfNumbers[k]})");
                        }
                        for (int l = 3; l <= length; l++)
                        {
                            if (setOfNumbers[i] + setOfNumbers[j] + setOfNumbers[k] + setOfNumbers[l] == sum)
                            {
                                Console.WriteLine($"({setOfNumbers[i]}, {setOfNumbers[j]}, {setOfNumbers[k]}, {setOfNumbers[l]})");
                            }
                            for (int m = 4; m <= length; m++)
                            {
                                if (setOfNumbers[i] + setOfNumbers[j] + setOfNumbers[k] + setOfNumbers[l] + setOfNumbers[m] == sum)
                                {
                                    Console.WriteLine($"({setOfNumbers[i]}, {setOfNumbers[j]}, {setOfNumbers[k]}, {setOfNumbers[l]  }, {setOfNumbers[m]})");
                                }

                            }

                        } 
                    }
                    
                }
            }
        }
        public static void Exercise10()
        {
            Console.WriteLine("Enter score from 1 to 9");
            int score = int.Parse(Console.ReadLine());
            if (score > 0 && score <=3)
            {
                score *= 10;
                Console.WriteLine(score);
            }
            else if (score >= 4 && score <= 6)
            {
                score *= 100;
                Console.WriteLine(score);
                
            }
            
            else if (score >= 7 && score <= 9)
            {
                score *= 1000;
                Console.WriteLine(score);
            }
            else
            {
                Console.WriteLine("Not in range");
            }
        }
        public static void Exercise11()
        {
            static string PrintUnits(int num)
            {
                switch(num)
                {
                    case 0: return "Zero";
                    case 1: return"One";
                    case 2: return "Two";
                    case 3: return "Three";
                    case 4: return "Four";
                    case 5: return "Five";
                    case 6: return "Six";
                    case 7: return "Seven";
                    case 8:  return "Eight";
                    case 9: return "Nine";
                    case 10: return "Ten";
                    case 11: return "Eleven";
                    case 12: return "Twelve";
                    case 13: return "Thirteen";
                    case 14: return "Fourteen";
                    case 15: return "Fifteen";
                    case 16: return "Sixteen";
                    case 17: return "Seventeen";
                    case 18: return "Eighteen";
                    case 19: return "Nineteen";
                    default: return " ";


                }
                 
            }

            static string PrintTens(int num)
            {
                
                switch (num)
                {
                    case 20: return"Twenty";
                    case 30: return"Thirty";
                    case 40: return"Forty";
                    case 50: return"Fifty";
                    case 60: return"Sixty";
                    case 70: return"Seventy";
                    case 80: return"Eighty";
                    case 90: return"Ninety";
                    case 100: return " Hundred";
                    default: return " ";
                }
               



            }
            static string PrintHundred(int num)
            {
                 
                    int hundreds = num / 100;
                    string hundredsWords = PrintUnits(hundreds);
                    return (hundredsWords + PrintTens(100));

                
            }
            static string PrintTensAndUnits(int num)
            {
                int units = num % 10;
                int tens = (num / 10) * 10;
                string tensWords = PrintTens(tens);
                string unitsWords = PrintUnits(units);
                return (tensWords + "-" + unitsWords);
            }
            Console.Write("Enter number: ");
            int num = int.Parse(Console.ReadLine());    
            if (num < 100 && num % 10 != 0)
            {
                string result = PrintTensAndUnits(num);
                Console.WriteLine(result);
            }
            else if(num <= 100 && num % 10 == 0)
            {
                string result = PrintTens(num);
                Console.WriteLine(result);
            }
            else if (num >= 0 && num <=19)
            {
                string result = PrintUnits(num);
                Console.WriteLine(result);
            }
            else if(num > 100)
            {
                int remainder = num % 100;
                bool Isremainder = (remainder != 0);
                string result = PrintHundred(num);
                if (Isremainder && remainder <= 20) 
                {
                     string value = PrintUnits(remainder);
                        
                     Console.WriteLine(result + " and " + value);
                    
                }
                else if(remainder > 20 && remainder % 10 == 0)
                {
                    string value = PrintTens(remainder);
                    Console.WriteLine(result + " and " + value);
                }
                else if(remainder > 20 && remainder % 10 != 0)
                {
                    string value = PrintTensAndUnits(remainder);
                    Console.WriteLine(result + " and " + value);
                }
                else
                {
                    Console.WriteLine(result);
                }
            }
            
        }
        
        
    }
}
