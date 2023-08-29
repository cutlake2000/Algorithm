using System;

public class Solution
{
    public int solution(int n)
    {
        int answer = 0;
        int length;
        string ternary = "";

        while (n != 0)
        {
            ternary += n % 3;
            n /= 3;
        }

        ternary.ToCharArray();

        length = ternary.Length;

        for (int i = 0; i < length; i++)
        {
            answer += (ternary[length - 1 - i] - 48) * (int)Math.Pow(3, i);
        }

        return answer;
    }
}
