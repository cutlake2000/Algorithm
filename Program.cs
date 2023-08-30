using System;

public class Program
{
    public static void Main(string[] args)
    {
        Solution solution = new Solution();

        // int a = 45;
        // int b = 10;
        // int c = 4;

        string a = "10203";
        string b = "15";

        // int[] a = { -3, -2, -1, 0, 1, 2, 3 };
        // int[] b = { -3, -1, 0, 2 };

        // int[,] a =
        // {
        //     { 1, 2 },
        //     { 2, 3 }
        // };
        // int[,] b =
        // {
        //     { 3, 4 },
        //     { 5, 6 }
        // };

        // string[] a = { "", "", "" };
        // string[] b = { "", "", "" };

        Console.Write(solution.solution(a, b));
    }
}
