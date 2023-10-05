using System;
using System.Collections.Generic;

public class Solution
{
    public string[] solution(string[] players, string[] callings)
    {
        string[] answer;

        Dictionary<string, int> playerToDic = new Dictionary<string, int>();

        for (int i = 0; i < players.Length; i++)
        {
            playerToDic.Add(players[i], i);
        }

        for (int i = 0; i < callings.Length; i++)
        {
            int num = playerToDic[callings[i]]--;

            string str = players[num - 1];

            players[num - 1] = players[num];
            players[num] = str;

            playerToDic[str]++;
        }

        answer = players;

        return answer;
    }
}
