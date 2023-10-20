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

            /**********************
             * Initializing variable instances
             * Declaring and initializing SentCnt
             ********************/
            #region variables
            WordCnt = 0;
            CharCnt = 0;
            NumCnt = 0;
            SpecCnt = 0;
            int SentCnt = 0;
            #endregion variables

            /***********************************************
             * Splitting input string into words and putting in array
             * Declaring and initializing character array for delimiter values
             * Splitting input string into sentences and putting in array
             ***********************************************/
            #region manipulations
            string[] words = inp.Split(' ');
            char[] delimiters = {'.', '!', '?'};
            string[] sentences = inp.Split(delimiters);
            #endregion manipulations

            /**************************************
             * Creating a for loop to work on the input string
             * Creating a for loop to work on the words array
             * Creating a for loop to work on the sentences array
             **************************************/

            #region loops
            /*for loop to iterate through input string and increase CharCnt
             * Also check increase SpecCnt by checking against letters or digits*/

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

            /*for loop to iterate through words array
             * Increase NumCnt after checking words with tryparse
             * Otherwise increase WordCnt*/

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

            /*for loop to iterate through sentences array and increase SentCnt*/

            for (int i = 1; i < sentences.Length; i++)
            {
                SentCnt++;
            }
            #endregion loops

            /*create object array to hold objects of multiple data types
             * fill object array countOut with output lines
             * Iterate through countOut and convert objects to string for printing*/
            #region output
            /*declaring and initializing object array countOut*/

            object[] countOut = { 
                "Word Count: " + WordCnt,
                "Sentence Count: " + SentCnt, 
                "Words per Sentence: " + (float)WordCnt/SentCnt,
                "Character Count: " + CharCnt,
                "Special Character Count: " + SpecCnt,
                "Characters per Sentence: " + (float)CharCnt/SentCnt,
                "Number Count: " + NumCnt
            };

            /*declaring and initializing stringOut array for converted objects*/

            string[] stringOut = Array.ConvertAll(countOut, x => x.ToString());

            /*create for loop to iterate through stringOut array and leverage
             *Output utility class to print all elements to the screen*/

            for (int i = 0; i < stringOut.Length; i++)
            {
                Output.Line(stringOut[i]);
            }
            #endregion output
            // THIS SHOULD BE THE LAST STATEMENT FOR MAIN
            Console.Read();
        }

    }
}
