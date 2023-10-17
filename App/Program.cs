using System;
using System.Linq;
using System.Text;
using System.IO;

namespace App
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Input: ");
            var inp = Console.ReadLine();
            Console.SetIn(new StreamReader(Console.OpenStandardInput(2048)));
            int WordCnt, CharCnt, NumCnt, SpecCnt;
            /********************** DO NOT EDIT ABOVE THIS LINE **********************************/
            #region variables
            WordCnt = 0;
            CharCnt = 0;
            NumCnt = 0;
            SpecCnt = 0;
            int LetrCnt = 0;
            int SentCnt = 0;
            #endregion variables

            #region manipulations
            string[] words = inp.Split(' ');
            char[] delimiters = { '.', '!', '?' };
            string[] sentences = inp.Split(delimiters);
            #endregion manipulations

            #region loops
            for (int i = 0; i < inp.Length; i++)
            {
                var c = inp[i];
                CharCnt++;
                if (c >= 'a' && c <= 'z' || c >= 'A' && c <= 'Z')
                {
                    LetrCnt++;
                }
                else if (c >= '0' && c <= '9')
                {
                    NumCnt++;
                }
                else
                {
                    SpecCnt++;
                }
            }

            for (int i = 0; i < words.Length; i++)
            {
                WordCnt++;
            }

            for (int i = 1; i < sentences.Length; i++)
            {
                SentCnt++;
            }
            #endregion loops

            #region ouput
            Console.WriteLine("Characters(ALL): " + CharCnt);
            Console.WriteLine("Special(Non-Alphanumeric): " + SpecCnt);
            Console.WriteLine("Letters(Alphabetic): " + LetrCnt);
            Console.WriteLine("Numbers(Numeric): " + NumCnt);
            Console.WriteLine("Words: " + WordCnt);
            Console.WriteLine("Sentences: " + SentCnt);
            Console.WriteLine("WPS: " + (float)WordCnt / SentCnt);
            Console.WriteLine("CPS: " + (float)CharCnt / SentCnt);
            Console.WriteLine("LPS: " + (float)LetrCnt / SentCnt);
            Console.WriteLine("LPW: " + (float)LetrCnt / WordCnt);
            #endregion output
            // THIS SHOULD BE THE LAST STATEMENT FOR MAIN
            Console.Read();
        }

    }
}
