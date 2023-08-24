using System;

public class Solution
{
    public int solution(int n)
    {
        int answer = 0;
        int digit = (int)Math.Floor(Math.Log10(n) + 1);
        int digitSquare = (int)Math.Pow(10, digit - 1);

        for (int i = 1; i <= digit; i++)
        {
            answer += (n / digitSquare);

            if (i != 9)
            {
                n %= digitSquare;
                digitSquare /= 10;
            }
        }
        return answer;
    }
}