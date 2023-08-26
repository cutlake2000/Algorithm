using System;

public class Solution
{
    public int solution(int[] numbers)
    {
        int[] compareNum = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        int answer = 0;

        for (int i = 0; i < numbers.Length; i++)
        {
            compareNum[numbers[i]] = 0;
        }

        for (int i = 0; i < compareNum.Length; i++)
        {
            answer += compareNum[i];
        }
        return answer;
    }
}
