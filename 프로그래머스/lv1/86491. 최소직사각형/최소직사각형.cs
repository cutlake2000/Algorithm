using System;

public class Solution
{
    public int solution(int[,] input)
    {
        int answer = 0;
        int xIndex = input.GetLength(0);
        int beforeTransformNums;
        int afterTransformNums;

        int[] minSize = { input[0, 0], input[0, 1] };

        for (int i = 1; i < xIndex; i++)
        {
            beforeTransformNums =
                CompareEachNums(minSize[0], input[i, 0]) + CompareEachNums(minSize[1], input[i, 1]);
            afterTransformNums =
                CompareEachNums(minSize[0], input[i, 1]) + CompareEachNums(minSize[1], input[i, 0]);

            if (beforeTransformNums < afterTransformNums)
            {
                SetEachNums(minSize, input[i, 1], input[i, 0]);
            }
            else
            {
                SetEachNums(minSize, input[i, 0], input[i, 1]);
            }
        }

        answer = minSize[0] * minSize[1];

        return answer;
    }

    public void SetEachNums(int[] minSize, int input0, int input1)
    {
        if (minSize[0] < input0)
        {
            minSize[0] = input0;
        }

        if (minSize[1] < input1)
        {
            minSize[1] = input1;
        }
    }

    public int CompareEachNums(int a, int b)
    {
        if ((a - b) >= 0)
        {
            return 0;
        }
        else
        {
            return a - b;
        }
    }
}
