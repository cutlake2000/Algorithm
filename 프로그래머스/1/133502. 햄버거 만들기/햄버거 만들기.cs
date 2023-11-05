using System;
using System.Collections.Generic;
using System.Linq;

public class Solution
{
    public int solution(int[] ingredient)
    {
        int answer = 0;
        int[] ingredientCopy = ingredient;
        int ingredientCopyIndex = ingredientCopy.Length;
        Stack<int> table = new Stack<int>();
        int[] hamburger = { 1, 2, 3, 1 };
        int[] compareHamburger = new int[4];

        for (int i = 0; i < ingredientCopyIndex; i++)
        {
            table.Push(ingredientCopy[i]);

            if (table.Count >= 4 && table.Peek() == 1)
            {
                compareHamburger[3] = table.Pop();
                compareHamburger[2] = table.Pop();
                compareHamburger[1] = table.Pop();
                compareHamburger[0] = table.Pop();

                if (Enumerable.SequenceEqual(hamburger, compareHamburger))
                {
                    answer++;
                }
                else
                {
                    table.Push(compareHamburger[0]);
                    table.Push(compareHamburger[1]);
                    table.Push(compareHamburger[2]);
                    table.Push(compareHamburger[3]);
                }
            }
        }

        return answer;
    }
}
