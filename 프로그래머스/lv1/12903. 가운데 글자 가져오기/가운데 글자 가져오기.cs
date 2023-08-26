public class Solution
{
    public string solution(string s)
    {
        string answer = "";
        int length = s.Length;
        int middleIndex = length / 2;

        char[] stringToChar = new char[length];

        stringToChar = s.ToCharArray();

        if (length % 2 == 0)
        {
            answer = stringToChar.GetValue(middleIndex - 1).ToString();
        }

        answer += (string)stringToChar.GetValue(middleIndex).ToString();

        return answer;
    }
}
