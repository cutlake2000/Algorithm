using System;

public class Solution
{
    public string solution(string[] survey, int[] choices)
    {
        int[] result = new int[8];
        string answer = "";

        for (int i = 0; i < survey.Length; i++)
        {
            if (choices[i] < 4)
            {
                result[ChangeStringToInt(survey[i][0])] += 4 - choices[i];
            }
            else if (4 < choices[i])
            {
                result[ChangeStringToInt(survey[i][1])] += choices[i] - 4;
            }
        }

        for (int i = 0; i < 4; i++)
        {
            char firstNum = ChangeIntToString(i * 2);
            char secondNum = ChangeIntToString(i * 2 + 1);

            char nowChar = result[i * 2] >= result[i * 2 + 1] ? firstNum : secondNum;
            answer += nowChar.ToString();
        }

        return answer;
    }

    public char ChangeIntToString(int a)
    {
        char value = ' ';

        switch (a)
        {
            case 0:
                value = 'R';
                break;
            case 1:
                value = 'T';
                break;
            case 2:
                value = 'C';
                break;
            case 3:
                value = 'F';
                break;
            case 4:
                value = 'J';
                break;
            case 5:
                value = 'M';
                break;
            case 6:
                value = 'A';
                break;
            case 7:
                value = 'N';
                break;
        }

        return value;
    }

    public int ChangeStringToInt(char a)
    {
        int value = 0;

        switch (a)
        {
            case 'R':
                value = 0;
                break;
            case 'T':
                value = 1;
                break;
            case 'C':
                value = 2;
                break;
            case 'F':
                value = 3;
                break;
            case 'J':
                value = 4;
                break;
            case 'M':
                value = 5;
                break;
            case 'A':
                value = 6;
                break;
            case 'N':
                value = 7;
                break;
        }

        return value;
    }
}
