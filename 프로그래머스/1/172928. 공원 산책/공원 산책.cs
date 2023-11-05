using System;
using System.Security;

public class Solution
{
    public int[] solution(string[] park, string[] routes)
    {
        int[] answer = new int[] { -1, -1 };
        int width = park[0].Length;
        int height = park.Length;

        for (int heightIndex = 0; heightIndex < height; heightIndex++)
        {
            if (answer[0] == -1)
            {
                for (int widthIndex = 0; widthIndex < width; widthIndex++)
                {
                    if (park[heightIndex][widthIndex] == 'S')
                    {
                        answer[0] = heightIndex;
                        answer[1] = widthIndex;

                        break;
                    }
                }
            }
            else
            {
                break;
            }
        }

        for (int i = 0; i < routes.Length; i++)
        {
            int checkJump = 0;
            int jump = routes[i][2] - '0';

            if (routes[i][0] == 'E')
            {
                checkJump = answer[1] + jump;

                if (checkJump < width)
                {
                    for (int j = 1; j <= jump; j++)
                    {
                        if (park[answer[0]][answer[1] + j] == 'X')
                        {
                            break;
                        }
                        else if (j == jump)
                        {
                            answer[1] = checkJump;
                        }
                    }
                }
            }
            else if (routes[i][0] == 'W')
            {
                checkJump = answer[1] - jump;

                if (0 <= checkJump)
                {
                    for (int j = 1; j <= jump; j++)
                    {
                        if (park[answer[0]][answer[1] - j] == 'X')
                        {
                            break;
                        }
                        else if (j == jump)
                        {
                            answer[1] = checkJump;
                        }
                    }
                }
            }
            else if (routes[i][0] == 'S')
            {
                checkJump = answer[0] + jump;

                if (checkJump < height)
                {
                    for (int j = 1; j <= jump; j++)
                    {
                        if (park[answer[0] + j][answer[1]] == 'X')
                        {
                            break;
                        }
                        else if (j == jump)
                        {
                            answer[0] = checkJump;
                        }
                    }
                }
            }
            else if (routes[i][0] == 'N')
            {
                checkJump = answer[0] - jump;

                if (0 <= checkJump)
                {
                    for (int j = 1; j <= jump; j++)
                    {
                        if (park[answer[0] - j][answer[1]] == 'X')
                        {
                            break;
                        }
                        else if (j == jump)
                        {
                            answer[0] = checkJump;
                        }
                    }
                }
            }
        }

        return answer;
    }
}
