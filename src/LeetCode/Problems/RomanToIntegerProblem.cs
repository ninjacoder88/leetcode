using System.Collections.Generic;

namespace LeetCode
{
    public class RomanToIntegerProblem
    {
        private Dictionary<char, int> _dictionary = new Dictionary<char, int> { {'I', 1},{'V', 5},{'X', 10},{'L', 50},{'C', 100},{'D', 500},{'M', 1000}, };

        public int RomanToInt(string s)
        {
            int total = 0;
            for(int i = 0; i < s.Length; i++)
            {
                var v0 = _dictionary[s[i]];
                if(i + 1 < s.Length)
                {
                    var v1 = _dictionary[s[i+1]];
                    if(v1 > v0)
                    {
                        total += v1 - v0;
                        i++;
                        continue;
                    }
                    total += v0;
                    continue;
                }
                total += v0;
            }
            return total;
        }
    }
}