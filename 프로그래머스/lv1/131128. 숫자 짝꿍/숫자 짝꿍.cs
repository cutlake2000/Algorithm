using System;
using System.Collections.Generic;
using System.Linq;

public class Solution
{
    public string solution(string X, string Y)
    {
        string answer = "";
        List<int> answerToList = new List<int>();

        int[] xNum = new int[10];
        int[] yNum = new int[10];
        int minNum;

        for (int i = 0; i < X.Length; i++)
        {
            xNum[X[i] - 48]++;
        }
        for (int i = 0; i < Y.Length; i++)
        {
            yNum[Y[i] - 48]++;
        }

        for (int i = 0; i < 10; i++)
        {
            minNum = xNum[i] <= yNum[i] ? xNum[i] : yNum[i];

            if (minNum != 0)
            {
                for (int j = 0; j < minNum; j++)
                {
                    answerToList.Add(i);
                }
            }
        }

        if (answerToList.Count == 0)
        {
            answer = "-1";
        }
        else
        {
            answerToList = answerToList.OrderByDescending(p => p).ToList();

            if (answerToList[0] == 0)
            {
                answer = "0";
            }
            else
            {
                answer = String.Join("", answerToList);
            }
        }

        return answer;
    }
}
