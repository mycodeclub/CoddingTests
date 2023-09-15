using System;
using CoddingTests.InterviewTests;
namespace CoddingTests
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var parser = new BracketParser();
            parser.RunTest();
            Console.WriteLine(parser.ValidateStringBrackets(null));
            parser.ValidateStringBrackets(null);
            Console.Read();
        }
    }
}
