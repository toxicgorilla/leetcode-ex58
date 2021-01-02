using System;
using System.Linq;

namespace LeetCode.Ex58
{
    public class Solution
    {
        public int LengthOfLastWord(string s)
        {
            var words = s.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            if (!words.Any())
            {
                return 0;
            }

            var lastWord = words.Last();

            return lastWord.Length;
        }
    }
}
