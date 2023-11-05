using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

public class Solution
{
    public int[] solution(string s)
    {
        int[] answer = new int[2];

        while (s != "1")
        {
            int num1Count = 0;
            int index = s.Length;

            // 모든 0 제거
            for (int i = 0; i < index; i++)
            {
                if (s[i] == '0')
                {
                    answer[1]++;
                }
                else
                {
                    num1Count++;
                }
            }

            // 길이를 2진법으로 변환
            s = Convert.ToString(num1Count, 2);

            answer[0]++;
        }

        return answer;
    }
}
