using System.Collections.Generic;
using System;
using System.Linq;

public class Solution
{
    public int[] solution(int[] answers)
    {
        int answersIndex = answers.Length;

        List<int> winner = new List<int>();
        int[] score = new int[3];

        int[] student1 = { 1, 2, 3, 4, 5 };
        int[] student2 = { 2, 1, 2, 3, 2, 4, 2, 5 };
        int[] student3 = { 3, 3, 1, 1, 2, 2, 4, 4, 5, 5 };

        for (int i = 0; i < answersIndex; i++)
        {
            if (student1[i % 5] == answers[i])
            {
                score[0]++;
            }
            if (student2[i % 8] == answers[i])
            {
                score[1]++;
            }
            if (student3[i % 10] == answers[i])
            {
                score[2]++;
            }
        }

        List<int> compareScore = score.ToList();
        compareScore = compareScore.OrderByDescending(x => x).ToList();

        for (int i = 0; i < 3; i++)
        {
            if (score[i] == compareScore[0])
            {
                winner.Add(i + 1);
            }
        }

        return winner.OrderBy(p => p).ToArray();
    }
}
