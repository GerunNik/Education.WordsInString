//-----------------------------------------------------------------------
// <copyright file="Program" company="CompanyName">
//     CountWordsInString.cs
// </copyright>
//-----------------------------------------------------------------------
namespace CountWordsInString
{
    using System;
    using System.IO;
    using System.Text;

    /// <summary>
    /// Its the Main Class
    /// </summary>
    public class Program
    {
        /// <summary>
        /// Its the Main Method
        /// </summary>
        /// <param name="args">It was automatically here</param>
        public static void Main(string[] args)
        {
            Console.WriteLine("Please enter a string in which I can count the words.");
            string stringToCount = File.ReadAllText(@"c:\ReadTxtFile\ReadMe.txt", Encoding.UTF8);
            //string stringToCount = "This is a test String";

            int countWords = 0;
            int totalChars = 0;
            char charBefore = ' ';

            foreach (char item in stringToCount)
            {
                totalChars++;
            }

            if (stringToCount != null)
            {
                foreach (char item in stringToCount)
                {
                    if (charBefore == ' ' && item != ' ')
                    {
                        countWords++;
                    }

                    charBefore = item;
                }
            }

            Console.WriteLine("You have this many Words in your sentence: " + countWords.ToString());
            Console.ReadKey();
        }
    }
}
