using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ProjectSolution
{
    public class Page454
    {
        public static void Number8()
        {
            int start = 0;
            while (start <= 1)
            {
                Console.Write("Enter start number: ");
                start = int.Parse(Console.ReadLine());
                if (start <= 1)
                {
                    Console.WriteLine("Enter a number greater 1");
                }
            }
            int end = 0;
            while (end >= 100)
            {


                Console.Write("Enter end number: ");
                end = int.Parse(Console.ReadLine());
                if(end >= 100)
                {
                    Console.WriteLine("Enter a number less than 100");
                }
            }
            ReadNumber(start, end);
        }
        public static void ReadNumber(int start, int end)
        {
            try
            {
                Console.Write("Enter number to be read: ");
                int number = int.Parse(Console.ReadLine());
                if (number < start || number > end)
                {
                    throw new Exception();
                }
                Console.WriteLine("The number is {0}", number);
            }
            catch (Exception e)
            {
                Console.WriteLine("Number is invalid or out of range", e);
            }

        }
        
        public static List<int> Number11()
        {
            return FileParse("readfile.txt");
        }
        public static List<int> FileParse(string fileName)
        {
            int lineNumber = 0;
            List<int> numbers = new List<int>();
            try
            {
                StreamReader reader = new StreamReader(fileName);
                using (reader)
                {
                    string line = reader.ReadLine();
                    while (line != null)
                    {
                        lineNumber++;
                        
                        if (line == null)
                        {
                            break;
                        }
                       int value = int.Parse(line);
                        numbers.Add(value);
                        line = reader.ReadLine();
                       
                    }
                }
                
            }
            catch(FileNotFoundException)
            {
                Console.WriteLine("This file does not exist");
            }
            catch(FormatException fe)
            {
                throw new FileParseException($"The file, {fileName} This does not contain an integer on line {lineNumber}", fileName, lineNumber, fe);
            }
            catch(Exception e)
            {
                Console.WriteLine("Something went wrong", e);
            }
            for(int i = 0; i < numbers.Count; i++)
            {
                Console.Write(numbers[i] + ", ");
            }
            return numbers;
        }

        public static void Number13()
        {
            string fileName = "coverpage1.jpg";
            string url = "https://images.hindustantimes.com/tech/img/2023/04/08/960x540/060_1643417994152_1680917609730_1680917609730.jpg";
            WebClient webClient = new WebClient();
            using (webClient)
            {
                try
                {
                    Console.WriteLine($"Downloading file....{fileName}");
                    webClient.DownloadFile(url, fileName);  
                    Console.WriteLine("File downloaded successfully");
                }
                catch(Exception e)
                {
                    Console.WriteLine("Couldn't download file", e);
                }
            }
        }
    }
}
