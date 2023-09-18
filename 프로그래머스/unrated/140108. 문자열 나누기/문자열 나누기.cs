using System;

public class Solution
{
    public int solution(string s)
    {
        int answer = 0;

        char matchChar = ' ';
        int[] matchCount = new int[2];

        int sIndex = s.Length;

        for (int i = 0; i < sIndex; i++)
        {
            if (matchChar == ' ')
            {
                matchChar = s[i];
            }

            if (s[i] == matchChar)
            {
                matchCount[0]++;
            }
            else
            {
                matchCount[1]++;
            }

            if (matchCount[0] == matchCount[1])
            {
                matchChar = ' ';
                matchCount[0] = matchCount[1] = 0;
                answer++;
            }
            else
            {
                if (i == sIndex - 1)
                {
                    answer++;
                    break;
                }
            }
        }

        return answer;
    }
}
