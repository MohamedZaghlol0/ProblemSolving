internal class Program
{
    private static void Main(string[] args)
    {
        Solution s1 = new Solution();
        int[] num = { 1, 2, 3, 4, 5 };

        s1.TwoSum(num, 4);

    }
    public class Solution
    {
        public int[] TwoSum(int[] nums, int target)
        {
            int[] arrsum = new int[2];
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = 0; j < nums.Length; j++)
                {
                    if (i == j)
                    {
                        continue;
                    }
                    else if (target == nums[i] + nums[j])
                    {
                        arrsum[0] = j;
                        arrsum[1] = i;
                    }
                }
            }
            foreach (int i in arrsum)
            {
                Console.WriteLine(i);
            }
            return arrsum;
        }
    }
}