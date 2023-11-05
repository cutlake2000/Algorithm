public class Solution
{
    public string solution(string s, int n)
    {
        string answer = "";
        char[] array = s.ToCharArray();
        int index = array.Length;

        for (int i = 0; i < index; i++)
        {
            if ('A' <= array[i] && array[i] <= 'Z')
            {
                if ((array[i] + n) > 'Z')
                {
                    array[i] = (char)(array[i] + n - 26);
                }
                else
                {
                    array[i] = (char)(array[i] + n);
                }
            }
            else if ('a' <= array[i] && array[i] <= 'z')
            {
                if ((array[i] + n) > 'z')
                {
                    array[i] = (char)(array[i] + n - 26);
                }
                else
                {
                    array[i] = (char)(array[i] + n);
                }
            }
        }

        answer = new string(array);

        return answer;
    }
}
