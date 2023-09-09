using System;
using System.Collections.Generic;

public class Solution
{
    public int solution(int number, int limit, int power)
    {
        int answer = 0;

        for (int i = 1; i <= number; i++)
        {
            if (CountDivisor(i) > limit)
            {
                answer += power;
            }
            else
            {
                answer += CountDivisor(i);
            }
        }

        return answer;
    }

    int CountDivisor(int input)
    {
        List<int> inputDivisor = new List<int>();
        int count = 0;
        int num = (int)Math.Sqrt(input);

        for (int i = 1; i <= num; i++)
        {
            if (input % i == 0)
            {
                inputDivisor.Add(i);
            }
        }

        int compareNum = inputDivisor[inputDivisor.Count - 1];

        count = inputDivisor.Count * 2;

        if ((input / compareNum) == compareNum)
        {
            count -= 1;
        }

        return count;
    }
}
