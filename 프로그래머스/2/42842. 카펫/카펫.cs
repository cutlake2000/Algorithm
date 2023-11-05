using System;
using System.Collections.Generic;
using System.Linq;

public class Solution
{
    public int[] solution(int brown, int yellow)
    {
        int[] answer = new int[2];
        int calNum = 0;

        List<int> divisorNum = new List<int>();

        int nowNum = 0;
        int tempNum = 0;
        int EntireNum = brown + yellow;
        int index = (int)MathF.Sqrt(EntireNum);

        for (int i = 1; i <= index; i++)
        {
            if (yellow % i == 0)
            {
                divisorNum.Add(i);
                divisorNum.Add(yellow / i);
            }
        }

        divisorNum = divisorNum.Distinct().ToList();

        index = divisorNum.Count;

        for (int i = 0; i < index; i++)
        {
            nowNum = divisorNum[i];
            tempNum = yellow / nowNum;

            calNum = (nowNum + tempNum + 2) * 2;

            if (calNum == brown)
            {
                answer[1] = nowNum + 2;
                answer[0] = tempNum + 2;
                break;
            }
            else
            {
                i++;
            }
        }

        return answer;
    }
}
