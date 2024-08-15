#include<bits/stdc++.h>

using namespace std;

vector<int> solution(vector<int> arr) 
{
    vector<int> answer;
    queue<int> q;
    
    for(auto i : arr){
        if ((q.size() > 0 && q.back() != i) || q.size() == 0){
            q.push(i);
            answer.push_back(i);
        }
    }

    return answer;
}