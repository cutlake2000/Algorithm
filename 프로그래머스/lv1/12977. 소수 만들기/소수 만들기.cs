using System;
using System.Text.RegularExpressions;

class Solution
{
    public int solution(int[] nums)
    {
        int answer = 0;

        int index = nums.Length;
        int primeNum;

        for (int i = 0; i < index - 2; i++)
        {
            for (int j = i + 1; j < index - 1; j++)
            {
                for (int k = j + 1; k < index; k++)
                {
                    primeNum = nums[i] + nums[j] + nums[k];

                    if (IsPrime(primeNum))
                    {
                        answer++;
                    }
                }
            }
        }

        return answer;
    }

    public bool IsPrime(int num)
    {
        bool primeNum = true;
        int index = (int)Math.Sqrt(num);

        for (int i = 2; i <= index; i++)
        {
            if (num % i == 0)
            {
                primeNum = false;
            }
        }

        return primeNum;
    }
}
