public class Solution
{
    public bool solution(string s)
    {
        bool answer = false;
        int length = s.Length;
        char[] array = new char[length];
        array = s.ToCharArray();

        if (s.Length == 4 || s.Length == 6)
        {
            for (int i = 0; i < length; i++)
            {
                if (48 <= array[i] && array[i] <= 57)
                {
                    answer = true;
                }
                else
                {
                    answer = false;
                    break;
                }
            }
        }
        return answer;
    }
}
