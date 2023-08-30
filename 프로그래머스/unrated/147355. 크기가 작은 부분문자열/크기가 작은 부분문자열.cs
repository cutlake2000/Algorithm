using System;

public class Solution
{
    public int solution(string t, string p)
    {
        int answer = 0;
        int lengthT = t.Length;
        int lengthP = p.Length;
        long numberP = StringToInt(p);

        for (int i = 0; i <= lengthT - lengthP; i++)
        {
            if (StringToInt(t.Substring(i, lengthP)) <= numberP)
            {
                answer++;
            }
        }

        return answer;
    }

    public long StringToInt(string num)
    {
        long number = 0;
        char[] array = num.ToCharArray();
        int length = array.Length;

        for (int i = 0; i < length; i++)
        {
            number += (array[length - 1 - i] - 48) * (long)Math.Pow(10, i);
        }

        return number;
    }
}
