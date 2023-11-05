public class Solution
{
    public string solution(string phone_number)
    {
        string answer = "";

        char[] answerArray = phone_number.ToCharArray();

        for (int i = 0; i < answerArray.Length - 4; i++)
        {
            answerArray[i] = '*';
        }

        answer = new string(answerArray);
        return answer;
    }
}
