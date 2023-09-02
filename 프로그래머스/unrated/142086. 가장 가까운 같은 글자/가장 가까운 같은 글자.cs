using System;
using System.Collections.Generic;
using System.Linq;

public class Solution
{
    public int[] solution(string s)
    {
        int index = s.Length;
        int[] answer = new int[index];
        List<char> list = new List<char>();

        for (int i = 0; i < index; i++)
        {
            if (!list.Contains(s[i]))
            {
                answer[i] = -1;
            }
            else
            {
                answer[i] = i - list.LastIndexOf(s[i]);
            }
            list.Add(s[i]);
        }

        return answer;
    }
}
