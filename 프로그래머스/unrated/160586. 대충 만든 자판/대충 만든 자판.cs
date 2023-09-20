using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

public class Solution
{
    public int[] solution(string[] keymap, string[] targets)
    {
        int targetsLength = 0;
        int keymapIndex = keymap.Length;
        int targetsIndex = targets.Length;

        List<int> tempKeymapList = new List<int>();

        int[] answer = new int[targetsIndex];

        for (int i = 0; i < targetsIndex; i++)
        {
            targetsLength = targets[i].Length;

            for (int j = 0; j < targetsLength; j++)
            {
                for (int k = 0; k < keymapIndex; k++)
                {
                    tempKeymapList.Add(Array.IndexOf(keymap[k].ToCharArray(), targets[i][j]) + 1);
                }

                tempKeymapList.RemoveAll(p => p == 0);

                if (tempKeymapList.Count != 0)
                {
                    tempKeymapList = tempKeymapList.OrderBy(p => p).ToList();
                    answer[i] += tempKeymapList[0];
                }
                else
                {
                    answer[i] = -1;
                    break;
                }

                tempKeymapList.Clear();
            }
        }

        return answer;
    }
}
