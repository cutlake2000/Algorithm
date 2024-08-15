#include<bits/stdc++.h>

using namespace std;

bool solution(string s)
{
    bool answer = true;
    int rightChecker = 0;
    stack<char> st;
    
    for(char c : s){
        st.push(c);
    }
    
    while(st.size() > 0){
        if (!answer) break;
        switch(st.top()){
            case '(':
                if (rightChecker > 0){
                    rightChecker--;
                    st.pop();
                }
                else{
                    answer = false;
                }
                break;
            case ')':
                rightChecker++;
                st.pop();
                break;
        }
    }
    
    if (rightChecker > 0) answer = false;

    return answer;
}