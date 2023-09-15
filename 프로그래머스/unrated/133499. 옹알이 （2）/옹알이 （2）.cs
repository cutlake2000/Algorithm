using System;

public class Solution
{
    public int solution(string[] babbling)
    {
        int answer = 0;
        int flag = 0;
        int pastFlag = 0;

        string[] babblingClone = (string[])babbling.Clone();
        string[] babyWord = { "aya", "ye", "woo", "ma" };

        int babblingCloneIndex = babblingClone.Length;
        int babyWordIndex = babyWord.Length;

        for (int i = 0; i < babblingCloneIndex; i++)
        {
            for (int j = 0; j < babyWordIndex; j++)
            {
                flag = babblingClone[i].IndexOf(babyWord[j]);

                if (flag != -1)
                {
                    do
                    {
                        babblingClone[i] = babblingClone[i]
                            .Remove(flag, babyWord[j].Length)
                            .Insert(flag, " ");

                        pastFlag = babblingClone[i].IndexOf(babyWord[j]);

                        if (pastFlag == flag + 1)
                        {
                            pastFlag = -1;
                        }
                        else if (pastFlag != -1)
                        {
                            flag = babblingClone[i].IndexOf(babyWord[j]);

                            if (flag == -1)
                            {
                                pastFlag = -1;
                            }
                        }
                    } while (pastFlag != -1);
                }
            }

            babblingClone[i] = babblingClone[i].Replace(" ", "");

            if (babblingClone[i].Length == 0)
            {
                answer++;
            }
        }

        return answer;
    }
}
