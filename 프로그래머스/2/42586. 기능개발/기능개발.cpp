#include<bits/stdc++.h>

using namespace std;

vector<int> solution(vector<int> progresses, vector<int> speeds) {
    vector<int> answer;
    queue<int> q;

    for (int i = 0 ; i < progresses.size() ; i++) {
        int target = ceil((100.0 - progresses[i]) / speeds[i]);
        q.push(target);
    }

    while(q.size() > 0) {
        int index = 0;
        int targetDay = q.front();

        q.pop();
        index++;

        while(q.size() > 0 && q.front() <= targetDay) {
            q.pop();
            index++;
        }

        answer.push_back(index);
    }

    return answer;
}