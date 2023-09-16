using System;
using System.Linq;

public class Solution
{
    public int solution(int n, int[] lost, int[] reserve)
    {
        // n : 총 학생 수
        // lost : 체육복을 잃어버린 학생 배열
        // reserve : 서브로 가지고 있는 학생 배열

        int answer = 0;
        int count = 0;
        int compareNum = 0;

        int[] student = new int[n + 1];
        int studentCount = student.Length;
        student[0] = 1; // 인덱스 0번은 버림

        reserve = reserve.OrderBy(p => p).ToArray();

        for (int i = 0; i < lost.Length; i++)
        {
            int findIndex = Array.IndexOf(reserve, lost[i]);

            // 잃어버린 학생 번호와 서브로 가지고 있는 학생 번호가 같은 경우 제거
            if (findIndex != -1)
            {
                reserve[findIndex] = -1;
            }
            else
            {
                student[lost[i]] = -1; // 체육복 안 가지고 온 학생 -1
                count++;
            }
        }

        for (int i = 0; i < reserve.Length; i++)
        {
            compareNum = reserve[i];

            if (compareNum != -1)
            {
                if (1 <= reserve[i] && student[compareNum - 1] == -1)
                {
                    student[compareNum - 1] = 0;
                    count--;
                }
                else if (compareNum <= studentCount - 2 && student[compareNum + 1] == -1)
                {
                    student[compareNum + 1] = 0;
                    count--;
                }
            }

            if (count == 0)
            {
                break;
            }
        }

        answer = n - count;

        return answer;
    }
}
