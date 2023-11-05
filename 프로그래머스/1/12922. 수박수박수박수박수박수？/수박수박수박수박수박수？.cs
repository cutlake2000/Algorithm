public class Solution
{
    public string solution(int n)
    {
        string answer = "";
        string su = "수";
        string bak = "박";

        for (int i = 1; i <= n; i++)
        {
            if (i % 2 != 0)
            {
                answer += su;
            }
            else
            {
                answer += bak;
            }
        }
        return answer;
    }
}
