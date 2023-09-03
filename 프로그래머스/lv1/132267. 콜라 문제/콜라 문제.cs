using System;

public class Solution
{
    public int solution(int emptyBottle, int newBottle, int remainBottle)
    {
        int answer = 0;
        int rest = 0;

        while (true)
        {
            if (remainBottle % emptyBottle != 0)
            {
                rest = remainBottle % emptyBottle;
            }

            remainBottle = remainBottle / emptyBottle * newBottle;
            answer += remainBottle;
            remainBottle += rest;
            rest = 0;

            if (remainBottle < emptyBottle)
            {
                break;
            }
        }

        return answer;
    }
}
