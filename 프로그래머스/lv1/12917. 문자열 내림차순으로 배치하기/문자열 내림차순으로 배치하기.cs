using System.Collections.Generic;
using System.Linq;

public class Solution
{
    public string solution(string s)
    {
        string answer = "";
        int length = s.Length;
        char[] toCharArray = new char[length];
        List<char> capital = new List<char>();
        List<char> lower = new List<char>();

        toCharArray = s.ToCharArray();

        for (int i = 0; i < length; i++)
        {
            if ('A' <= toCharArray[i] && toCharArray[i] <= 'Z')
            {
                capital.Add(toCharArray[i]);
            }
            else
            {
                lower.Add(toCharArray[i]);
            }
        }

        lower = lower.OrderByDescending(p => p).ToList();
        capital = capital.OrderByDescending(p => p).ToList();

        answer = new string(lower.ToArray()) + new string(capital.ToArray());

        return answer;
    }
}
