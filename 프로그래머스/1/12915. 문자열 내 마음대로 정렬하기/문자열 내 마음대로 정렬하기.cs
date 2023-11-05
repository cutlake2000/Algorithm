using System;

public class Solution
{
    public string[] solution(string[] strings, int n)
    {
        string[] answer = new string[] { };

        for (int i = 0; i < strings.Length - 1; i++)
        {
            for (int j = i + 1; j < strings.Length; j++)
            {
                var compareNum1 = Convert.ToChar(strings[i].Substring(n, 1));
                var compareNum2 = Convert.ToChar(strings[j].Substring(n, 1));

                if (compareNum1 > compareNum2)
                {
                    var tmp = strings[i];
                    strings[i] = strings[j];
                    strings[j] = tmp;
                }
                else if (compareNum1 == compareNum2)
                {
                    int index =
                        strings[i].Length > strings[j].Length
                            ? strings[j].Length
                            : strings[i].Length;

                    for (int k = 0; k < index; k++)
                    {
                        var compareOtherNum1 = Convert.ToChar(strings[i].Substring(k, 1));
                        var compareOtherNum2 = Convert.ToChar(strings[j].Substring(k, 1));

                        if (compareOtherNum1 != compareOtherNum2)
                        {
                            if (compareOtherNum1 > compareOtherNum2)
                            {
                                var tmp = strings[i];
                                strings[i] = strings[j];
                                strings[j] = tmp;
                            }

                            break;
                        }
                        else if (k == index - 1)
                        {
                            if (index != strings[i].Length)
                            {
                                var tmp = strings[i];
                                strings[i] = strings[j];
                                strings[j] = tmp;
                            }
                        }
                    }
                }
            }
        }

        answer = strings;

        return answer;
    }
}
