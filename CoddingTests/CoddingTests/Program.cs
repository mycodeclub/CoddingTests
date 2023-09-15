using System;
using CoddingTests.InterviewTests;
namespace CoddingTests
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var reverse = new Reverse();
            Console.WriteLine(reverse.ReverseCharactersOfWordsInString(null));
            Console.WriteLine(reverse.ReverseCharactersOfWordsInString("the   blue car"));
            Console.WriteLine(reverse.ReverseCharactersOfWordsInString(string.Empty));
            Console.WriteLine(reverse.ReverseCharactersOfWordsInString("the   blue car @#        d      s   $%^^&*(("));
            Console.Read();
        }
    }
}
