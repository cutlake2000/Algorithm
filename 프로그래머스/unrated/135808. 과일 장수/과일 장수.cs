using System;
using System.Collections.Generic;
using System.Linq;

public class Solution
{
    public int solution(int k, int m, int[] score)
    {
        int answer = 0;
        List<int> scoreToList = score.OrderByDescending(p => p).ToList();

        int index = scoreToList.Count / m;

        for (int i = m - 1; i < index * m; i += m)
        {
            answer += scoreToList[i];
        }

        return answer * m;
    }
}
