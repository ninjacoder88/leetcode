using System;
using System.Linq;

namespace LeetCode
{
    public static class DumpExtensions
    {
        public static int[] Dump(this int[] array)
        {
            Console.Write(string.Join(" ", array.Select(x => x.ToString())));
            return array;
        }
    }
}