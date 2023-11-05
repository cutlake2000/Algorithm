using System;

public class Solution
{
    public int solution(string s)
    {
        int answer = 0;
        int tmpNum = 0;
        int lenght = s.Length;
        char firstNum = s.ToCharArray()[0];

        if (!(49 <= firstNum && firstNum <= 57))
        {
            tmpNum++;
        }

        for (int i = tmpNum += answer; i < lenght; i++)
        {
            answer += (s.ToCharArray()[i] - 48) * (int)Math.Pow(10, lenght - i - 1);
        }

        if (firstNum == '-')
        {
            answer *= -1;
        }

        return answer;
    }
}
