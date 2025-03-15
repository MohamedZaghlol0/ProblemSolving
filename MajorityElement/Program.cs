using System.Collections.Concurrent;

internal class Program
{
    private static void Main(string[] args)
    {
        int[] nums = { 3, 2, 3 };
        Solution solution = new Solution();
        solution.MajorityElement(nums);
    }

}
public class Solution
{
    public int MajorityElement(int[] nums)
    {
        int[] freq = {} ;
        int count  ;

        for (int i = 0; i < nums.Length; i++) 
        {
            count = 0;
            for (int j = 0; j < nums.Length; j++) 
            {
                if (nums[i] == nums[j])
                {
                    count++;
                    freq.Append(count);

                }
            }

        }
        foreach (var item in freq)
        {
            Console.WriteLine(item);
        } 

        return 0;
    }
}