using System;
using System.Linq;
namespace CoddingTests.InterviewTests
{
    public static class StringShorting
    {
        public static string ShortString(string S = "1,2,1,4")
        {
            string result = "-404";
            int[] numArr = S.Split(',').Select(int.Parse).ToArray();


            var tempVarForSwap = 0;
            for (int i = 0; i < numArr.Length; i++)
            {
                for (int j = i + 1; j < numArr.Length - 1; j++)
                {
                    if (numArr[i] > numArr[j])
                    {
                        tempVarForSwap = numArr[i];
                        numArr[i] = numArr[j];
                        numArr[j] = tempVarForSwap;
                    }
                }
            }
            result = string.Join(",", numArr); 
            Console.WriteLine(result);
            Console.ReadLine();
            return result;

        }
    }
}
