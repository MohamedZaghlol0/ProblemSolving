internal class Program
{
    private static void Main(string[] args)
    {
        Solution solution = new Solution();
        solution.FinalPrices([8, 4, 6, 2, 3]);
    }
    public class Solution
    {
        public int[] FinalPrices(int[] prices)
        {
            for (int i = 0; i < prices.Length; i++)
            {
                for (int j = i + 1; j < prices.Length; j++)
                {
                    if (prices[j] <= prices[i])
                    {
                        prices[i] -= prices[j];
                        break;
                    }
                }
            }

            foreach (var item in prices)
            {
                Console.WriteLine(item);
            }
            return prices;
        }
    }
}