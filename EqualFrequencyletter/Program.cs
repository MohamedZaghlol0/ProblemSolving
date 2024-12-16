internal class Program
{
    private static void Main(string[] args)
    {
        Solution solution = new Solution();
        solution.EqualFrequency("abcc");
    }
    public class Solution
    {
        public bool EqualFrequency(string word)
        {
            bool result = true;
            int repeated = 0;
            int repindx = 0;
            char[] words = word.ToCharArray();
            for (int i = 0; i < words.Length - 1; i++)
            {
                int frq = 0;
                
                for (int j = 0; j < word.Length - 1; j++)
                {
                    if (words[i] == word[j])
                    {
                       frq += 1;
                    }
                    if (frq >= 2) 
                    {
                        result = false;

                    }
                }    

            }
            if (repeated == 1) 
            {
                word.Remove(repindx);
            }
            Console.WriteLine(word)    ;
            return result;
        }
    }
}