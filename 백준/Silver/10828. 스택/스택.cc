#include<bits/stdc++.h>
using namespace std;

int main(){
  ios::sync_with_stdio(0);
  cin.tie(0);
  
  stack<int> s;

  int r;
  cin >> r;

  while(r--){
    string input;
    cin >> input;
    if (input == "push"){
      int input2;
      cin >> input2;
      s.push(input2);
    }
    else if (input == "pop"){
      if (s.size() > 0){
        cout << s.top() << "\n";
        s.pop();
        }
      else cout << -1 << "\n";
    }
    else if (input == "size"){
      cout << s.size() << "\n";
    }
    else if (input == "empty"){
      cout << (int) (s.size() == 0) << "\n";
    }
    else if (input == "top"){
      if (s.size() > 0) cout << s.top() << "\n";
      else cout << -1 << "\n";
    }
  }
}