using System;

public class Solution
{
    public long solution(int[] a, int[] b)
    {
        int index = a.Length;
        long answer = 0;

        for (int i = 0; i < index; i++)
        {
            answer += (a[i] * b[i]);
        }
        return answer;
    }
}
