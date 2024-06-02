#include<bits/stdc++.h>
using namespace std;

const int MX = 1000005;
int st[MX];
int pos = 0;

void Push(int x){
  st[pos++] = x;
}

void Pop(){
  pos--;
}

int Top(){
  return st[pos - 1];
}

int main(){
  ios::sync_with_stdio(0);
  cin.tie(0);
  
  int repeatCount;
  cin >> repeatCount;

  while(repeatCount--){
    string command;
    cin >> command;

    if(command == "push"){
      int num;
      cin >> num;
      Push(num);
    }
    else if(command == "pop"){
      if (pos > 0){
        cout << Top() << "\n";
        Pop();
        }
      else cout << -1 << "\n";
    }
    else if(command == "size"){
      cout << pos << "\n";
    }
    else if(command == "empty"){
      cout << (int)(pos == 0) << "\n";
    }
    else if(command == "top"){
      if (pos > 0) cout << Top() << "\n";
      else cout << -1 << "\n";
    }
  }
}