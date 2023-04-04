using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Xsl;

namespace ProgrammingFundamentalsPractice.Chapter_15
{
    public class ChapterFifteenExercises
    {
        public static void Exercise1()
        {
            string fileName = "readfile.txt";
            try
            {
                StreamReader reader = new StreamReader(fileName);
                using (reader)
                {
                    int lineNumber = 0;
                    string line = reader.ReadLine();
                    while (line != null)
                    {
                        lineNumber++;

                        if (lineNumber % 2 != 0)
                        {
                            Console.WriteLine("Line {0}: {1}", lineNumber, line);
                            line = reader.ReadLine();
                        }
                        else
                        {
                            line = reader.ReadLine();
                            continue;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public static void Exercise2()
        {
            string firstFile = "readfile.txt";
            string secondFile = "Morechanges.txt";
            string result = "resultfile.txt";

            StreamReader reader = new StreamReader(firstFile);
            StreamWriter writer = new StreamWriter(result, false);
       
            
            using(reader)
            {
                using(writer)
                {
                    string line;
                    int lineNumber = 0;
                    int i = 1;
                    while((line = reader.ReadLine()) != null)
                    {
                        lineNumber++;
                        
                        while (i <= lineNumber)
                        {
                            writer.WriteLine(i+". " + line);
                            i++;
                        }
                    }
                }
            }
            StreamReader streamReader = new StreamReader(secondFile);
            writer = new StreamWriter(result, true);

            

            using(streamReader)
            {
                using(writer)
                {
                    string line;
                    while((line = streamReader.ReadLine()) != null)
                    {
                            writer.WriteLine(line);
                    }
                }
            }
            StreamReader readResult = new StreamReader(result);

                using(readResult)
                {
                    string line;
                    while ((line = readResult.ReadLine()) != null)

                    {
                    Console.WriteLine(line);
                    }

                }
             

        }
        public static void Exercise3() 
        {
            StreamReader reader = new StreamReader("readfile.txt");
            StreamWriter writer = new StreamWriter("dummyfile.txt", false);
            using(reader) 
            {
                using (writer)
                {
                    string line;
                    int lineNumber = 0; 
                    int i = 1;
                    while ((line = reader.ReadLine()) != null) 
                    {
                        lineNumber++;

                        writer.WriteLine(lineNumber + ". " + line);
                        //while (i <= lineNumber)
                        //{
                        //}
                        //i++;
                    }
                }
            }

            StreamReader anotherReader = new StreamReader("dummyfile.txt");
            StreamWriter anotherWriter = new StreamWriter("readfile.txt", false);


            using (anotherReader)
            {
                using (anotherWriter)
                {
                    string line;
                    while ((line = anotherReader.ReadLine()) != null)
                    {
                        anotherWriter.WriteLine(line);
                        Console.WriteLine(line);
                    }
                }
            }

        }
        StringBuilder
    }
    
}