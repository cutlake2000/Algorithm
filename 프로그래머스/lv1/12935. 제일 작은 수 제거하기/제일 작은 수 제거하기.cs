using System;
using System.Collections.Generic;
using System.Linq;

public class Solution
{
    public int[] solution(int[] arr)
    {
        List<int> list = arr.ToList();

        int[] answer = new int[] { };
        int minNum = arr[0];

        for (int i = 0; i < list.Count; i++)
        {
            if (minNum > arr[i])
            {
                minNum = arr[i];
            }
        }

        list.Remove(minNum);

        if (list.Count == 0)
        {
            list.Add(-1);
        }

        answer = list.ToArray();

        return answer;
    }
}
