#include<bits/stdc++.h>
using namespace std;

int main(){
  ios::sync_with_stdio(0);
  cin.tie(0);

  queue<int> Q;

  int r;
  cin >> r;

  while(r--){
    string i1;
    cin >> i1;

    if (i1 == "push"){
      int i2;
      cin >> i2;
      Q.push(i2);
    }
    else if (i1 == "pop"){
      if (!Q.empty()){
        cout << Q.front() << "\n";
        Q.pop();
      }
      else cout << -1 << "\n";
    }
    else if (i1 == "size"){
      cout << Q.size() << "\n";
    }
    else if (i1 == "empty"){
      cout << Q.empty() << "\n";
    }
    else if (i1 == "front"){
      if (!Q.empty()) cout << Q.front() << "\n";
      else cout << -1 << "\n";
    }
    else if (i1 == "back"){
      if (!Q.empty()) cout << Q.back() << "\n";
      else cout << -1 << "\n";
    }
  }
}