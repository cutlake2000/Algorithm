public class Solution
{
    public int[] solution(int n, int m)
    {
        int[] answer = new int[2];
        int smallNum = n >= m ? m : n;
        bool isEnd = false;
        int leastCommonMultiple = 1;

        while (isEnd == false)
        {
            for (int i = 2; i <= smallNum; i++)
            {
                if (n % i == 0 && m % i == 0)
                {
                    leastCommonMultiple *= i;
                    n /= i;
                    m /= i;
                    break;
                }

                if (i == smallNum)
                {
                    isEnd = true;
                }
            }
        }

        answer[0] = leastCommonMultiple;
        answer[1] = leastCommonMultiple * n * m;

        return answer;
    }
}
