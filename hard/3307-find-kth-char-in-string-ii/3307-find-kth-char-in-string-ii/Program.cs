using System;
using System.Text;

public class Program
{
    static void Main()
    {
        var sol = new Solution();

        //Testcases
        // Console.WriteLine(sol.KthCharacter(5, [0, 0, 0]));
        // Console.WriteLine(sol.KthCharacter(10, [0, 1, 0, 1]));
        Console.WriteLine(sol.KthCharacter(488855,
            [0, 1, 1, 1, 0, 1, 0, 1, 1, 1, 1, 1, 0, 1, 1, 0, 1, 1, 1, 1, 0, 0, 1, 1, 1]));
    }
}

public class Solution
{
    public char KthCharacter(long k, int[] operations)
    {
        char c = 'a';
        int exp = 0;
        int shiftCount = 0;

        for (int i = 0; i < operations.Length; i++)
        {
            if (Math.Pow(2, i + 1) >= k)
            {
                exp = i;
                break;
            }
        }

        for (int i = exp; i >= 0; i--)
        {
            if (operations[i] == 0)
            {
                if (k > (Math.Pow(2, i)))
                {
                    k = k - (long)Math.Pow(2, i);
                }
            }
            else if (operations[i] == 1)
            {
                if (k > (Math.Pow(2, i)))
                {
                    k = k - (long)Math.Pow(2, i);
                    shiftCount++;
                }
            }
        }

        for (int i = 0; i < shiftCount; i++)
        {
            if (c == 'z')
            {
                c = 'a';
            }
            else
            {
                c = (char)(c + 1);
            }
        }

        return c;
    }
}