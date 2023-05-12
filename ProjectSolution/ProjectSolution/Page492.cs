using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Threading.Tasks;

namespace ProjectSolution
{
    public class Page492
    {
        public static void Number8()
        {
            string inputString = "Test";
            char[] inpustStringCharArray = inputString.ToCharArray();
            List<ushort> listOfChars = new List<ushort>();
            for(int i = 0; i < inpustStringCharArray.Length; i++)
            {
                char j = inpustStringCharArray[i];
                ushort sampleText = (ushort)j;
                listOfChars.Add(sampleText);
            }
            for(int i = 0; i < listOfChars.Count; i++)
            {
                Console.Write("\\u{0:x4}",listOfChars[i]);
            }
        }
         public static void Number9()
         {
            string sourceText = "Test";
            char [] sourceTextCharArray = sourceText.ToCharArray();
            string cipherCode = "ab";
           char[] cipherCodeCharArray = cipherCode.ToCharArray();
            List<ushort> encryption = new List<ushort>();
            for (int i = 0; i < sourceTextCharArray.Length; i++)
            {
                var j = sourceTextCharArray[i];
                char k = j;
                var l = cipherCodeCharArray[i % cipherCodeCharArray.Length];
                char m = l;
                ushort text = (ushort)k;
                ushort code = (ushort)m;
              
                var t = text ^ code;
                encryption.Add((ushort)t);
            }
            for(int i = 0; i < encryption.Count; i++)
            {
                Console.Write("\\u{0:x4}", encryption[i]);
            }
         }
        
        public static void Number10()
        {
            string sentences1 = "We are living in a yellow submarine. We don't have anything else. Inside the submarine is very tight. So we are drinking " +
                "all the day. We will move out of it in 5 days.";
            string sentences = sentences1.ToLower();
            string keyword = " in ";
            char separator = '.';
            string[] sentence = sentences.Split(separator);
            List<string> keywordSentences = new List<string>();
            for (int i = 0; i < sentence.Length; i++) 
            {
                if (sentence[i].Contains(keyword))
                {
                    
                    keywordSentences.Add(sentence[i]);
                }
                else
                {
                    continue;
                }
            }
            for(int i = 0; i < keywordSentences.Count; i++)
            {
                Console.WriteLine(keywordSentences[i]);
            }
        }

        public static void Number13()
        {
            string url = "https://www.victory-osamede-blogs/1/pic";
            string [] separators = { "://", "/"," " };
            string[] urlParts =  url.Split(separators, StringSplitOptions.RemoveEmptyEntries);
            string? protocol = null;
            string? server = null;
            string? resource = null;
            List<string?> list = new List<string?>();
            for (int i = 0; i < urlParts.Length; i++)
            {
                protocol = urlParts[0];
                server = urlParts[1];
                 
                if (i > 1)
                {
                    list.Add ("/" + urlParts[i]);
                   
                }
            }
            Console.WriteLine($"[protocol] = \"{protocol}\"");
            Console.WriteLine($"[server] = \"{server}\"");
            Console.Write("[resource] = \"");
            for (int i = 0; i < list.Count; i++)
            {
                Console.Write($"{list[i]}");
            }
            Console.Write("\"");
        }
    }
}
