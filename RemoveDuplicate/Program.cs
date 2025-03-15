internal class Program
{
    private static void Main(string[] args)
    {
        Solution solution = new Solution();
        int[] nums = { 0, 0, 1, 1, 1, 2, 2, 3, 3, 4 };
        Console.WriteLine(solution.RemoveDuplicates(nums)); 
    }

    public class Solution
    {
        int count = 0;
        public int RemoveDuplicates(int[] nums)
        {
            if (nums.Length == 0)
            {
                return 0;
            }
            for (int i = 0; i < nums.Length - 1; i++)
            {
                for (int j = 0; j < nums.Length - 1; j++)
                {
                    if (i == j) 
                    {
                        continue; 
                    }
                    if (nums[i] == nums[j])
                    {
                        nums[j] = -1;
                    }
                }
            }
            foreach (var num in nums)
            {
                if (num == -1)
                {
                    count++;
                }
            }
            return count;
        }
    }
}