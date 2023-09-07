using System;

public class Solution
{
    public int solution(int n, int m, int[] section)
    {
        int answer = 0;
        int index = section.Length;
        int nowIndex = 0;
        int checkIndex = 1;

        while (true)
        {
            if (checkIndex <= index - 1)
            {
                if ((section[nowIndex] + m - 1) >= section[checkIndex])
                {
                    checkIndex++;
                }
                else
                {
                    answer++;
                    nowIndex = checkIndex;
                }
            }
            else
            {
                answer++;
                break;
            }
        }

        return answer;
    }
}
