using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ProgrammingFundamentalsPractice.Chapter_13
{
    public class ChapterThirteenExercises
    {
        public static void Exercise2()
        {
            string text = "introduction";
            string reverse = ReverseText(text);
            Console.WriteLine(reverse);
        }
        public static string ReverseText(string text)
        {
            StringBuilder sb = new StringBuilder();
            for(int i = text.Length - 1; i >= 0; i--)
            {
                sb.Append(text[i]);
            }
            return sb.ToString();
        }
        public static void Exercise3()
        {

            Console.WriteLine("Enter an expression");
            string expression = Console.ReadLine();
            StringBuilder sb = new StringBuilder();
            for(int i = 0; i < expression.Length; i++)
            {
                sb.Append(expression[i]);
            }
            sb.ToString();
            string open = "(";
            string close = ")";
            int values = 0;
            for(int i = 0; i < sb.Length; i++)
            {
                if (sb[0].Equals(close))
                {
                    Console.WriteLine("not placed correctly");
                    break;
                }
                else if (sb[0].Equals(open))
                {
                    continue;
                }
                if (!(sb[i].Equals(open)) && !(sb[i].Equals(close)))
                {
                    values++;
                }
                else
                {
                    continue;
                }
                if (sb[sb.Length-1].Equals(open))
                {
                    Console.WriteLine("Not placed correctly");
                }
                
                 
            }

        }
        public static void Exercise4()
        {
            string listOfBeers = "Amstel, \\ , Heineken, \\,  Tuborg, \\, Becks";
            char[] separators = new char[] {'\\', ','};
            string[] beersArr = listOfBeers.Split('\n');
            foreach(string beer in beersArr)
            {
                Console.WriteLine( beer);
            }
            Console.Read();
        }

        public static void Exercise5()
        {
            string quote = "We are living in a yellow submarine. We don't have anything else." +
                " In side the submarine is very tight. So we are drinking all the day." +
                " We will move out of it in 5 days.";

            string lowerCaseQuote = quote.ToLower();
            string keyword = "in";
            int index = lowerCaseQuote.IndexOf(keyword);

            while(index != -1)
            {
                Console.WriteLine("{0} found at index: {1}",keyword, index);
                index = lowerCaseQuote.IndexOf(keyword, index + 1);
                
            }
        }
        public static void Exercise6()
        {
            string text = "We are living in a <upcase>yellow submarine</upcase>. " +
                "We don't have <upcase>anything</upcase> else.";
            string keyword1 = "<upcase>";
            string keyword2 = "</upcase>";

          
            
        }
    }
}
