public class Solution
{
    public long[] solution(long x, int n)
    {
        long[] answer = new long[n];
        long increaseNum = x;

        answer[0] = x;

        for (int i = 1; i < n; i++)
        {
            x += increaseNum;
            answer[i] = x;
        }
        return answer;
    }
}