using System;

public class Solution
{
    public int solution(int[] absolutes, bool[] signs)
    {
        int index = absolutes.Length;
        int answer = 0;

        for (int i = 0; i < index; i++)
        {
            answer += signs[i] == true ? absolutes[i] : absolutes[i] * -1;
        }

        return answer;
    }
}
