using System;

public class Solution
{
    public int solution(string s)
    {
        int answer = 0;

        bool isMatch = false;

        char matchChar = ' ';
        int[] matchCount = new int[2];

        int sIndex = s.Length;

        for (int i = 0; i < sIndex; i++)
        {
            if (isMatch == false)
            {
                matchChar = s[i];

                isMatch = true;
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
                isMatch = false;
                matchCount[0] = matchCount[1] = 0;
                answer++;
            }
        }

        return answer;
    }
}
