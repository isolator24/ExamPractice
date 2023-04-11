using System;

namespace ExamPractice
{
    public static class SortArrayByStringLength
    {
        public static string[] Process(string[] array)
        {
            // Two solutions, 2nd is preferred
            Array.Sort(array, (x, y) => x.Length.CompareTo(y.Length));
            
            array.OrderBy(e => e.Length).ToArray();

            foreach (var item in array)
            {
                Console.WriteLine(item);
            }
            return array;
        }
    }
}
