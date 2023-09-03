using System;
using System.Collections.Generic;
using System.Linq;

public class Solution
{
    public string solution(string[] cards1, string[] cards2, string[] goal)
    {
        string answer = "Yes";

        List<string> card1ToList = cards1.ToList();
        List<string> card2ToList = cards2.ToList();
        List<string> goalToList = goal.ToList();

        while (goalToList.Count != 0)
        {
            if (card1ToList.Count != 0 && card1ToList[0].Equals(goalToList[0]))
            {
                goalToList.RemoveAt(0);
                card1ToList.RemoveAt(0);
            }
            else if (card2ToList.Count != 0 && card2ToList[0].Equals(goalToList[0]))
            {
                goalToList.Remove(card2ToList[0]);
                card2ToList.RemoveAt(0);
            }
            else
            {
                answer = "No";
                break;
            }
        }

        return answer;
    }
}
