using System;
using System.Collections.Generic;
using System.Linq;

public class Solution
{
    public int[] solution(int[] array, int[,] commands)
    {
        int commandsRowIndex = commands.GetLength(0);
        int[] answer = new int[commandsRowIndex];
        List<int> arrayToList = new List<int>();

        for (int i = 0; i < commandsRowIndex; i++)
        {
            arrayToList.Clear();

            int startIndex = commands[i, 0] - 1;
            int endIndex = commands[i, 1];

            for (int j = startIndex; j < endIndex; j++)
            {
                arrayToList.Add(array[j]);
            }

            arrayToList = arrayToList.OrderBy(p => p).ToList();

            answer[i] = arrayToList[commands[i, 2] - 1];
        }

        return answer;
    }
}
