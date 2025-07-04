using System;
using System.Text;

public class Program
{
    static void Main()
    {
        var sol = new Solution();

        //Testcases
        Console.WriteLine(sol.KthCharacter(5));
        Console.WriteLine(sol.KthCharacter(10));
    }
}

public class Solution
{
    public char KthCharacter(int k)
    {
        char word = 'a';

        int exp = 0;

        for (int i = 0; true; i++)
        {
            if (Math.Pow(2, i) >= k)
            {
                exp = i;
                break;
            }
        }

        StringBuilder sb = new StringBuilder();
        sb.Append(word);

        for (int i = 0; i <= exp; i++)
        {
            StringBuilder sb1 = new StringBuilder();

            int sbLength = sb.Length;
            for (int j = 0; j < sbLength; j++)
            {
                char nextChar;
                if (sb[j] == 'z')
                {
                    nextChar = 'a';
                }
                else
                {
                    nextChar = (char)(sb[j] + 1);
                }

                sb1.Append(nextChar);
            }

            sb.Append(sb1);
        }

        return sb[k - 1];
    }
}