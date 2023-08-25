using System;

public class Solution
{
    public long solution(long n)
    {
        long answer = 0;
        long tmpNum = 0;
        int length = (int)(Math.Log10(n) + 1);
        long[] compareNum = new long[length];

        for (int i = 1; i <= length; i++)
        {
            tmpNum = (n % Pow(i));

            if (i != 1)
            {
                tmpNum = (tmpNum - (tmpNum % Pow(i - 1))) / Pow(i - 1);
            }

            compareNum[i - 1] = tmpNum;
        }

        for (int i = 0; i < length; i++)
        {
            for (int j = i + 1; j < length; j++)
            {
                if (compareNum[i] < compareNum[j])
                {
                    tmpNum = compareNum[i];
                    compareNum[i] = compareNum[j];
                    compareNum[j] = tmpNum;
                }
            }

            answer += (compareNum[i] * Pow(length - i - 1));
        }

        return answer;
    }

    public long Pow(int i)
    {
        return (long)Math.Pow(10, i);
    }
}
