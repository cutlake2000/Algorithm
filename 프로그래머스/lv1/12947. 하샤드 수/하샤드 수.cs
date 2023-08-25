using System;

public class Solution
{
    public bool solution(int x)
    {
        int length = (int)(Math.Log10(x) + 1);
        int num = 0;
        int sum = 0;
        bool answer = false;

        for (int i = 1; i <= length; i++)
        {
            num = x % Pow10(i);

            if (i != 1)
            {
                num = (num - num % Pow10(i - 1)) / Pow10(i - 1);
            }

            sum += num;
        }

        if (x % sum == 0)
        {
            answer = true;
        }

        return answer;
    }

    public int Pow10(int pow)
    {
        return (int)Math.Pow(10, pow);
    }
}
