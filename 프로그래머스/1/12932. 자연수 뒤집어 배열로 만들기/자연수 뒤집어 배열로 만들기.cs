using System;

public class Solution
{
    public int[] solution(long n)
    {
        int length = (int)(Math.Log10(n) + 1);
        int[] answer = new int[length];
        long num = 0;

        for (int i = 1; i <= length; i++)
        {
            num = (n % Pow(i));

            if (i != 1)
            {
                num = (num - (num % Pow(i - 1))) / Pow(i - 1);
            }

            answer[i - 1] = (int)num;
        }
        return answer;
    }

    public long Pow(int i)
    {
        return (long)Math.Pow(10, i);
    }
}
