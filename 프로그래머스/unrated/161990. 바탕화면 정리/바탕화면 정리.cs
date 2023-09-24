using System;

public class Solution
{
    public int[] solution(string[] wallpaper)
    {
        int[] answer = new int[4];
        int columnIndex = wallpaper.Length;
        int rowIndex = wallpaper.Length;

        string[] wallpaperCopy = new string[columnIndex];
        Array.Copy(wallpaper, wallpaperCopy, wallpaper.Length);

        bool initArray = false;

        int firstCheckChar;
        int secondCheckChar;

        for (int i = 0; i < columnIndex; i++)
        {
            firstCheckChar = wallpaperCopy[i].IndexOf("#");

            if (firstCheckChar != -1)
            {
                wallpaperCopy[i] = wallpaper[i]
                    .Remove(firstCheckChar, 1)
                    .Insert(firstCheckChar, "v");

                secondCheckChar = wallpaperCopy[i].LastIndexOf("#");

                if (initArray == false)
                {
                    answer[0] = i;
                    answer[1] = firstCheckChar;
                    answer[2] = i + 1;
                    answer[3] = firstCheckChar + 1;

                    initArray = true;
                }

                if (firstCheckChar < answer[1])
                {
                    answer[1] = firstCheckChar;
                }

                if (secondCheckChar == -1)
                {
                    if (answer[2] - 1 < i)
                    {
                        answer[2] = i + 1;
                    }
                    if (answer[3] - 1 < firstCheckChar)
                    {
                        answer[3] = firstCheckChar + 1;
                    }
                }
                else
                {
                    if (answer[2] - 1 < i)
                    {
                        answer[2] = i + 1;
                    }
                    if (answer[3] - 1 < secondCheckChar)
                    {
                        answer[3] = secondCheckChar + 1;
                    }
                }
            }
        }

        return answer;
    }
}
