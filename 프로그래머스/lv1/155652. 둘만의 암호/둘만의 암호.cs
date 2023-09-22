using System;
using System.Diagnostics;
using System.Linq;

public class Solution
{
    public string solution(string s, string skip, int index)
    {
        string answer = "";
        char[] sArray = s.ToCharArray();
        char[] skipArray = skip.OrderBy(p => p).ToArray();

        int sIndex = sArray.Length;
        int skipIndex = skipArray.Length;

        char nextChar = ' ';

        for (int i = 0; i < sIndex; i++)
        {
            nextChar = sArray[i];

            for (int j = 1; j <= index; j++)
            {
                do
                {
                    nextChar++;

                    if (nextChar > 'z')
                    {
                        nextChar = (char)(nextChar - 26);
                    }
                } while (Array.Exists(skipArray, p => p == nextChar));
            }

            while (Array.IndexOf(skipArray, nextChar) != -1)
            {
                nextChar = (char)(nextChar + 1);
            }

            sArray[i] = nextChar;
        }

        answer = new string(sArray);

        return answer;
    }
}
