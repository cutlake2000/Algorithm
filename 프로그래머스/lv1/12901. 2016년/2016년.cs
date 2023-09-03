public class Solution
{
    public string solution(int a, int b)
    {
        string answer = "";
        int[] date = { 31, 29, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
        string[] day = { "FRI", "SAT", "SUN", "MON", "TUE", "WED", "THU" };

        int month2Day = 0;
        int calDay = 0;

        for (int i = 0; i < a - 1; i++)
        {
            month2Day += date[i];
        }

        if ((month2Day + b) >= 7)
        {
            calDay = (month2Day + b) % 7;
        }
        else
        {
            calDay = month2Day + b;
        }

        if (calDay == 0)
        {
            calDay = 7;
        }

        answer = day[calDay - 1];

        return answer;
    }
}
