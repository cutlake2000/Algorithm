using System;
using System.Collections.Generic;

public class Solution
{
    public int[] solution(string today, string[] terms, string[] privacies)
    {
        int[] answer;
        List<int> answerList = new List<int>();

        int termsIndex = terms.Length;
        int privaciesIndex = privacies.Length;

        for (int i = 0; i < privaciesIndex; i++)
        {
            int todayYear = Int32.Parse(today.Substring(0, 4));
            int todayMonth = Int32.Parse(today.Substring(5, 2));
            int adjustPrivaciesYear = 0;
            int adjustPrivaciesMonth = 0;

            for (int j = 0; j < termsIndex; j++)
            {
                if (privacies[i][11] == terms[j][0])
                {
                    adjustPrivaciesYear = Int32.Parse(privacies[i].Substring(0, 4));
                    adjustPrivaciesMonth =
                        Int32.Parse(privacies[i].Substring(5, 2))
                        + Int32.Parse(terms[j].Substring(2));

                    if (adjustPrivaciesMonth >= 13)
                    {
                        int adjustMonth = adjustPrivaciesMonth / 12;

                        if (adjustPrivaciesMonth % 12 == 0)
                        {
                            adjustMonth--;
                        }
                        adjustPrivaciesYear += adjustMonth;
                        adjustPrivaciesMonth -= (12 * adjustMonth);
                    }

                    if (todayYear > adjustPrivaciesYear)
                    {
                        answerList.Add(i + 1);
                    }
                    else if (todayYear == adjustPrivaciesYear)
                    {
                        if (todayMonth > adjustPrivaciesMonth)
                        {
                            answerList.Add(i + 1);
                        }
                        else if (todayMonth == adjustPrivaciesMonth)
                        {
                            int todayDay = Int32.Parse(today.Substring(8, 2));
                            int privaciesDay = Int32.Parse(privacies[i].Substring(8, 2));

                            if (todayDay >= privaciesDay)
                            {
                                answerList.Add(i + 1);
                            }
                        }
                    }

                    break;
                }
            }
        }

        answer = answerList.ToArray();

        return answer;
    }
}
