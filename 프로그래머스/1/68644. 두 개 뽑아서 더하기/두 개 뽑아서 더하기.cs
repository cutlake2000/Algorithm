using System;
using System.Collections.Generic;
using System.Linq;

public class Solution
{
    public int[] solution(int[] numbers)
    {
        List<int> numbersToArray = new List<int>();
        int index = numbers.Length;
        int[] answer = new int[] { };

        for (int i = 0; i < index - 1; i++)
        {
            for (int j = i + 1; j < index; j++)
            {
                int sum = numbers[i] + numbers[j];

                if (!numbersToArray.Contains(sum))
                {
                    numbersToArray.Add(sum);
                }
            }
        }

        answer = numbersToArray.OrderBy(p => p).ToArray();

        return answer;
    }
}
