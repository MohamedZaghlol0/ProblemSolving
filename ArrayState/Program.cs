internal class Program
{
    private static void Main(string[] args)
    {
        int[] myarr = [2, 1, 3, 5, 6];
        Solution solution = new Solution();
        solution.GetFinalState(myarr,5,2);
    }
    public class Solution
    {
        public int[] GetFinalState(int[] nums, int k, int multiplier)
        {
            for (int j = 0; j < k; j++)
            {
                int minValue = nums[0];
                int minIndex = 0;

                for (int i = 1; i < nums.Length; i++)
                {
                    if (nums[i] < minValue)
                    {
                        minValue = nums[i];
                        minIndex = i;
                    }
                }
                nums[minIndex] *= multiplier;
            }

            return nums;
        }
    }
}
