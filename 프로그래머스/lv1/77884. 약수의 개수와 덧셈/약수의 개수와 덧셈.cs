using System;

public class Solution
{
    public int solution(int left, int right)
    {
        int answer = 0;
        int count;

        for (int i = left; i <= right; i++)
        {
            count = 2;
            if (IsEvenNum(i) == false)
            {
                if (i % (i / 2 + 1) == 0)
                {
                    count++;
                }
            }

            for (int j = 2; j <= i / 2; j++)
            {
                if (i % j == 0)
                {
                    count++;
                }
            }

            if (IsEvenNum(count) == true)
            {
                answer += i;
            }
            else
            {
                answer -= i;
            }
        }
        return answer;
    }

    public bool IsEvenNum(int input)
    {
        if (input % 2 == 0)
        {
            return true;
        }
        else
            return false;
    }
}
