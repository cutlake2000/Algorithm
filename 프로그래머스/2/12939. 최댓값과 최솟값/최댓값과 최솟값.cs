using System;
using System.Linq;

public class Solution
{
        public string solution(string s)
        {
            string answer = "";

            // 공백을 기준으로 문자열을 나눈다
            string[] s_array = s.Split(' ');
            // 문자열 배열에 있는 요소들을 int로 형변환
            int[] num_array = Array.ConvertAll(s_array, num => int.Parse(num));

            // 정답형식에 맞게 문자열 완성
            answer = num_array.Min().ToString() + " " + num_array.Max().ToString();

            return answer;
        }
}