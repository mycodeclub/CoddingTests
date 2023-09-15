using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoddingTests.InterviewTests
{
    public class Reverse
    {
        public string ReverseCharactersOfWordsInString(string inputString)
        {
            if (string.IsNullOrWhiteSpace(inputString))
            {
                //  Console.WriteLine("Invalid Input");
                return inputString;
            }

            var wordArray = inputString.Split(' ');


            var outputString = new StringBuilder();
            foreach (var word in wordArray)
            {
                var charArray = word.ToCharArray();
                for (int i = charArray.Length - 1; i >= 0; i--)
                    outputString.Append(charArray[i]);
                outputString.Append(" ");
            }
            return outputString.ToString();
        }
    }
}
