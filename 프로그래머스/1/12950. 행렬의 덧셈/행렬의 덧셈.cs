public class Solution
{
    public int[,] solution(int[,] arr1, int[,] arr2)
    {
        int rowLength = arr1.GetLength(0);
        int columnLength = arr1.GetLength(1);

        int[,] answer = new int[rowLength, columnLength];

        for (int i = 0; i < rowLength; i++)
        {
            for (int j = 0; j < columnLength; j++)
            {
                answer[i, j] = arr1[i, j] + arr2[i, j];
            }
        }
        return answer;
    }
}
