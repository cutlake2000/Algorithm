using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

public class Solution
{
    public string solution(string s)
    {
        string answer = "";
        int checkIndex = 0;
        int nowIndex = 0;

        char[] stringToArray = s.ToLower().ToCharArray();

        for (int i = 0; i < stringToArray.Length; i++)
        {
            if (97 <= stringToArray[i] && stringToArray[i] <= 122)
            {
                stringToArray[i] = char.ToUpper(stringToArray[i]);
            }

            nowIndex = Array.FindIndex(stringToArray, i, p => p == ' ');

            if (nowIndex == -1)
            {
                break;
            }
            else
            {
                i = nowIndex;
            }
        }

        answer = String.Join(string.Empty, stringToArray);

        return answer;
    }
}
