using System;

public class Solution
{
    public string solution(int[] food)
    {
        string answer;
        int[] answerArray;
        int stringIndex = 0;
        int answerIndex = 0;
        int iIndex = food.Length;

        for (int i = 1; i < iIndex; i++)
        {
            if (!(food[i] % 2 == 0))
            {
                food[i] -= 1;
            }

            answerIndex += food[i];
        }
        answerIndex++;

        answerArray = new int[answerIndex];

        for (int i = 1; i < iIndex; i++)
        {
            for (int j = 1; j <= (food[i] / 2); j++)
            {
                answerArray[stringIndex] = i;
                answerArray[answerIndex - stringIndex - 1] = i;
                stringIndex++;
            }
        }

        answerArray[answerIndex / 2] = 0;

        answer = string.Join("", answerArray);

        return answer;
    }
}
