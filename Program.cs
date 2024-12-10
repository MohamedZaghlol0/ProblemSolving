using System.Diagnostics.Contracts;
using System.Security.Cryptography.X509Certificates;

internal class Program
{
    private static void Main(string[] args)
    {
     Solution s1 = new Solution();
        s1.IsPalindrome(-121);
    }
    public class Solution
    {
        public bool IsPalindrome(int x)
        {
            bool result;
            if (x < 0)
                return result = false;

            char[] numstr = x.ToString().ToCharArray();
            int L = numstr.Length;
            char[] temp = new char[L];
            for (int i =0 ; i <= L-1; i++) 
            {
                temp[L - i - 1] = numstr[i];
            }
            result = true;
            for (int i = 0; i < L; i++)
            {
                if (numstr[i] != temp[i])
                {
                    result = false;
                    break;
                }
            }
            foreach (char a in numstr)
            {
                Console.WriteLine(a);
            }
            foreach (char b in temp)
            {
                Console.WriteLine(b);
            }
            Console.WriteLine(result);
            return result;
        }
    }
}
