public class Solution
{
    public string solution(string[] seoul)
    {
        int index = 0;

        foreach (string name in seoul)
        {
            if (name == "Kim")
                break;
            else
                index++;
        }
        string answer = "김서방은 " + index + "에 있다";
        return answer;
    }
}
