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
            int SentCnt = 0;
            #endregion variables

            #region manipulations
            string[] words = inp.Split(' ');
            char[] delimiters = {'.', '!', '?'};
            string[] sentences = inp.Split(delimiters);
            #endregion manipulations

            #region loops
            for (int i = 0; i < inp.Length; i++)
            {
                var c = inp[i];
                CharCnt++;
                if (char.IsLetterOrDigit(c) == false && c != ' ')
                {
                    SpecCnt++;
                }
                else
                {
                    continue;
                }
            }

            for (int i = 0; i < words.Length; i++)
            {
                int result;
                bool num = int.TryParse(words[i], out result);
                if (result != 0)
                {
                    NumCnt++;
                }
                else
                {
                    WordCnt++;
                }
            }

            for (int i = 1; i < sentences.Length; i++)
            {
                SentCnt++;
            }
            #endregion loops

            #region output
            object[] countOut = { 
                "Word Count: " + WordCnt,
                "Sentence Count: " + SentCnt, 
                "Words per Sentence: " + (float)WordCnt/SentCnt,
                "Character Count: " + CharCnt,
                "Special Character Count: " + SpecCnt,
                "Characters per Sentence: " + (float)CharCnt/SentCnt,
                "Number Count: " + NumCnt
            };
            string[] stringOut = Array.ConvertAll(countOut, x => x.ToString());
            for (int i = 0; i < countOut.Length; i++)
            {
                Output.Line(stringOut[i]);
            }
            #endregion output
            // THIS SHOULD BE THE LAST STATEMENT FOR MAIN
            Console.Read();
        }

    }
}
