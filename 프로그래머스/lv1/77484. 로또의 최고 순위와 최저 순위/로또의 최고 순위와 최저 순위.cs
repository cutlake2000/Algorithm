using System;
using System.Collections.Generic;
using System.Linq;

public class Solution
{
    public int[] solution(int[] lottos, int[] win_nums)
    {
        int[] answer = new int[2];
        int defaultAnswer = 0;
        int extraAnswer = 0;

        List<int> winNumList = win_nums.ToList();

        int winLottoIndex = winNumList.Count;
        int lottosIndex = lottos.Length;

        for (int i = 0; i < lottosIndex; i++)
        {
            int compareNum = lottos[i];

            if (compareNum == 0)
            {
                extraAnswer++;
            }
            else
            {
                for (int j = 0; j < winLottoIndex; j++)
                {
                    if (compareNum == winNumList[j])
                    {
                        winNumList.RemoveAt(j);
                        defaultAnswer++;
                        winLottoIndex--;
                    }
                }
            }
        }

        answer[0] = CalculateRate(defaultAnswer + extraAnswer);
        answer[1] = CalculateRate(defaultAnswer);

        return answer;
    }

    public int CalculateRate(int defaultAnswer)
    {
        int answer;

        switch (defaultAnswer)
        {
            case 6:
                answer = 1;
                break;
            case 5:
                answer = 2;
                break;
            case 4:
                answer = 3;
                break;
            case 3:
                answer = 4;
                break;
            case 2:
                answer = 5;
                break;
            default:
                answer = 6;
                break;
        }

        return answer;
    }
}
