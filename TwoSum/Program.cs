﻿internal class Program
{
    private static void Main(string[] args)
    {
        Solution s1 = new Solution();
        s1.RomanToInt("III");
    }
    public class Solution
    {
        public int RomanToInt(string s)
        {
            int result = 0;
            Dictionary<char, int> romanMap = new Dictionary<char, int>
        {
            {'I', 1},
            {'V', 5},
            {'X', 10},
            {'L', 50},
            {'C', 100},
            {'D', 500},
            {'M', 1000}
        };

            for (int i = 0; i < s.Length; i++)
            {
                if (i < s.Length - 1 && romanMap[s[i]] < romanMap[s[i + 1]])
                {
                    result -= romanMap[s[i]];
                }
                else
                {
                    result += romanMap[s[i]];
                }

            }
            Console.WriteLine(result);
            return result;
        }
    }
}