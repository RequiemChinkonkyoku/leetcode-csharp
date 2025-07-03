using System;
using System.Text;

public class Program
{
    static void Main()
    {
        var sol = new Solution();

        //Testcases
        Console.WriteLine(string.Join(", ", sol.TwoSum(new int[] { 2, 7, 11, 15 }, 9)));
        Console.WriteLine(string.Join(", ", sol.TwoSum(new int[] { 3, 2, 4 }, 6)));
        Console.WriteLine(string.Join(", ", sol.TwoSum(new int[] { 3, 3 }, 6)));
    }
}

public class Solution
{
    public int[] TwoSum(int[] nums, int target)
    {
        int[] result = new int[2];

        for (int i = 0; i < nums.Length; i++)
        {
            int num1 = nums[i];
            for (int j = i + 1; j < nums.Length; j++)
            {
                int num2 = nums[j];

                if (num1 + num2 == target)
                {
                    result[0] = i;
                    result[1] = j;
                    break;
                }
            }
        }

        return result;
    }
}