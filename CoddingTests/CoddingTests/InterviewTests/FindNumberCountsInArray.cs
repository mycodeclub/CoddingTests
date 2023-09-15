using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoddingTests.InterviewTests
{
    public static class FindCharCounts
    {
        public static void FindNumberCountsFromIntArray(int[] _myArray)
        {
            Console.WriteLine("Counting character / Numbers count exist in given array.");

            if (_myArray == null || _myArray.Count() > 0)
                _myArray = new int[] { 5, 4, 5, 9, 8, 4, 5, 3, 4, 3, 3, 2, 3, 4, 5, 6, 7, 8, 9 };

            var counts = new List<Counting>();

            int i; int j; int k;
            for (i = 0; i < _myArray.Length; i++)
            {
                if (counts.Any(c => c.key.Equals(_myArray[i])))
                    continue;
                Counting count = new Counting() { key = _myArray[i], count = 1 };
                for (j = i + 1; j < _myArray.Length; j++)
                    if (count.key == _myArray[j])
                        count.count++;
                counts.Add(count);
            }

            Console.WriteLine( "Char  |  Count" );
            foreach (var count in counts)
            {
                Console.WriteLine(count.key + "     |  " + count.count);
            }
            Console.WriteLine("______________");
        }
    }

    public class Counting
    {
        public int key { get; set; }
        public int count { get; set; }

    }
}
