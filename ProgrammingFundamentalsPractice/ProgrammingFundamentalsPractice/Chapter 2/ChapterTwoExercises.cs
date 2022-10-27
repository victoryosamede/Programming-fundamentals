using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingFundamentalsPractice.Chapter_2
{
    public class ChapterTwoExercises
    {
        public static void Exercise1()
        {
            ushort ushortNum = 52310;
            sbyte sbyteNum = -115;
            uint intNum = 4825932;
            byte byteNum = 97;
            short shortNum = -10000;
            ushort ushortNumTwo = 20000;
            byte byteNumTwo = 224;
            uint uintNumTwo = 970000000;
            byte byteNumThree = 112;
            sbyte sbyteNumTwo = -44;
            int intNumTwo = -1000000;
            ushort ushortNumThree = 1990;
            long longNum = 123456789123456789;

            Console.WriteLine("ushort =" + ushortNum);
            Console.WriteLine("sbyte =" + sbyteNum);
            Console.WriteLine("int = " + intNum);
            Console.WriteLine("byte =" + byteNum);
            Console.WriteLine("short =" + shortNum);
            Console.WriteLine("ushort =" + ushortNumTwo);
            Console.WriteLine("byte =" + byteNumTwo);
            Console.WriteLine("uint =" + uintNumTwo);
            Console.WriteLine("byte =" + byteNumThree);
            Console.WriteLine("sbyte =" + sbyteNumTwo);
            Console.WriteLine("int =" + intNumTwo);
            Console.WriteLine("ushort =" + ushortNumThree);
            Console.WriteLine("long =" + longNum);
            


        }
        
        public static void Exercise2()
        {
            float numFive = 5;
            float decimalNumFive = 5.01f;
            double numThirtyFour = 34.567839023;
            float numTwelve = 12.345f;
            float floatNum = 8923.1234857f;
            decimal veryLargeNum = 3456.091124875956542151256683467m;

            Console.WriteLine(numFive + " " + "is a float.");
            Console.WriteLine(decimalNumFive + " " + "is a float.");
            Console.WriteLine(numThirtyFour + " " + "is a double.");
            Console.WriteLine(numTwelve + " " + "is a float.");
            Console.WriteLine(floatNum + " " + "is a float.");
            Console.WriteLine(veryLargeNum + " " + "is a decimal.");
        }
        public static void Exercise3()
        {
            float a = 22.0000025f;
            float b = 22.0000022f;

            bool compare = (a - b) < 0.000001;

            Console.WriteLine(compare);
            
        }

        public static void Exercise4()
        {
            int hex = 0x100;
            Console.WriteLine(hex);
        }

        public static void Exercise5()
        {
            int unicodeChar = '\u0048';
            Console.WriteLine(unicodeChar);
        }

        public static void Exercise6()
        {
            bool isMale = false;

            Console.WriteLine(isMale);
        }

        public static void Exercise7()
        {
            string hello = "Hello" + " ";
            string world = "World";
            object helloWorld = hello + world;

           Console.WriteLine(helloWorld);
        }

        public static void Exercise8()
        {
            string hello = "Hello" + " ";
            string world = "World";
            object helloWorld = hello + world;
            string concatTwo = (string)helloWorld;
            Console.WriteLine(concatTwo);
        }

        public static void Exercise9()
        {
            string withQuotes = "The \"use\" of quotations causes difficulties.";
            string without = "\"The \"use\" of quotations causes difficulties.\"";

             Console.WriteLine(withQuotes);
             Console.WriteLine(without);
        }

        public static void Exercise10()
        {
            Console.WriteLine("       o   o     ");
            Console.WriteLine("     o   o   o   ");
            Console.WriteLine("      o     o    ");
            Console.WriteLine("        o o      ");
            Console.WriteLine("         o       ");
        }

        public static void Exercise11()
        {

            Console.WriteLine("                            '\u00A9'                     ");
            Console.WriteLine("                          '\u00A9' '\u00A9'                ");
            Console.WriteLine("                        '\u00A9'     '\u00A9'              ");
            Console.WriteLine("                      '\u00A9' '\u00A9' '\u00A9''\u00A9'           ");


        }

        public static void Exercise12()
        {
            string firstName;
            string lastName;
            char genderMOrF;
            int age;
            Console.WriteLine("Declaration");
        }

        public static void Exercise13()
        {
            int numFive = 5;
            int numTen = 10;

            int swap = numFive;
            numFive = numTen;
            numTen = swap;

            Console.WriteLine(numFive);
            Console.WriteLine(numTen);
        }
    }
}
