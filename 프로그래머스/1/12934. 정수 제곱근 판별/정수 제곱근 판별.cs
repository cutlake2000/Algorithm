using System;

public class Solution
{
    public long solution(double n)
    {
        long answer = 0;
        double tmpNum = Math.Sqrt(n);

        if (tmpNum % 1 == 0)
        {
            answer = (long)Math.Pow(tmpNum + 1, 2);
        }
        else
        {
            answer = -1;
        }
        return answer;
    }
}
