using System;

public class Solution
{
    public string solution(string s)
    {
        string answer = "";
        char[] array = s.ToCharArray();
        int index = 0;

        int length = array.Length;

        for (int i = 0; i < length; i++)
        {
            if (array[i] != ' ')
            {
                if (index % 2 == 0)
                {
                    array[i] = Char.ToUpper(array[i]);
                }
                else
                {
                    array[i] = Char.ToLower(array[i]);
                }
                index++;
            }
            else
            {
                index = 0;
            }
        }

        answer = new string(array);

        return answer;
    }
}
