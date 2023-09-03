using System;
using System.Collections.Generic;
using System.Linq;

public class Solution
{
    public int[] solution(int k, int[] score)
    {
        List<int> honor = new List<int>();
        int index = score.Length;
        int[] answer = new int[index];

        for (int i = 0; i < index; i++)
        {
            honor.Add(score[i]);
            honor = honor.OrderBy(p => p).ToList();

            if (honor.Count > k)
            {
                honor.RemoveAt(0);
            }

            answer[i] = honor.First();
        }

        return answer;
    }
}
