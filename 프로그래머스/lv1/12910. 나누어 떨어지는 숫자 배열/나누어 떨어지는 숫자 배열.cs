using System.Collections.Generic;

public class Solution
{
    public int[] solution(int[] arr, int divisor)
    {
        List<int> answerList = new List<int>();
        int[] answer = new int[] { };

        int arrLength = arr.Length;

        for (int i = 0; i < arrLength; i++)
        {
            if (arr[i] % divisor == 0)
            {
                answerList.Add(arr[i]);
            }
        }

        if (answerList.Count == 0)
        {
            answerList.Add(-1);
        }
        else
        {
            answerList.Sort();
        }

        answer = answerList.ToArray();

        return answer;
    }
}
