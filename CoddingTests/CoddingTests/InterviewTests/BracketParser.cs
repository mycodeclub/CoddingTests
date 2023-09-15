using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoddingTests.InterviewTests
{
    internal class BracketParser
    {
        public bool ValidateStringBrackets(string inputString)
        {
            return Validate(inputString);

        }
        public void RunTest()
        {
            var validStingOutput = TestValidString();
            var invalidStingOutpt = TestInvalidString();
            Console.WriteLine("Valid Sting Output: " + validStingOutput + " || " + "Invalid Sting Output" + invalidStingOutpt);
        }

        private bool TestValidString()
        {
            var validInputString = "This is a input string (sentence) for which parsing code need to check for {,(,[ closing properly])}";
            return Validate(validInputString);
        }
        private bool TestInvalidString()
        {
            var inValidInputString = "This is a input string (sentence) for which parsing code need to check for {,(,[ closing properly , make sure its not having any wrong input braces like (]";
            return Validate(inValidInputString);
        }

        private bool Validate(string inputString)
        {
            var validationStack = new Stack();

            List<KeyValuePair<char, char>> validationRules = new List<KeyValuePair<char, char>>()
            {
                new KeyValuePair<char, char>('(', ')'),
                new KeyValuePair<char, char>('{', '}'),
                new KeyValuePair<char, char>('[', ']'),
                new KeyValuePair<char, char>('<', '>'),

            };
            if (string.IsNullOrEmpty(inputString)) { Console.WriteLine("You provided an empty string  "); }
            else
            {
                var charArray = inputString.ToCharArray();
                foreach (char c in charArray)
                {
                    var charOpenBracketMatch = validationRules.Where(item => item.Key.Equals(c)).FirstOrDefault();
                    var charCloseBracketMatch = validationRules.Where(item => item.Value.Equals(c)).FirstOrDefault();

                    if (c.Equals(charOpenBracketMatch.Key))
                    {
                        validationStack.Push(charOpenBracketMatch);
                        continue;
                    }
                    else if (charCloseBracketMatch.Value.Equals(c))
                    {
                        if (validationStack.Count > 0)
                            validationStack.Pop();
                        else return false;
                    }
                }
            }
            return validationStack.Count == 0;

        }
    }
}
