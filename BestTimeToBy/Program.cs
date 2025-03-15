internal class Program
{
    private static void Main(string[] args)
    {
        Solution solution = new Solution();
        int[] prices = { 7, 1, 5, 3, 6, 4 };
        int result = solution.MaxProfit(prices);
        Console.WriteLine(result);

    }
}
public class Solution
{
    public int MaxProfit(int[] prices)
    {
        int minPrice = int.MaxValue;
        int maxProfit = 0;

        foreach (int price in prices)
        {
            minPrice = Math.Min(minPrice, price);
            maxProfit = Math.Max(maxProfit, price - minPrice);
        }

        return maxProfit;
    }

}