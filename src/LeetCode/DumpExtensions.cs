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

        public static string Dump(this string str)
        {
            Console.WriteLine(str);
            return str;
        }

        public static int Dump(this int val)
        {
            Console.WriteLine(val);
            return val;
        }
    }
}