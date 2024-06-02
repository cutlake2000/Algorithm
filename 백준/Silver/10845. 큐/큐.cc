#include<bits/stdc++.h>
using namespace std;

const int MX = 1000005;
int Q[MX];
int head, tail = 0;

void push(int x){
  Q[tail++] = x;
}

void pop(){
  head++;
}

int front(){
  return Q[head];
}

int back(){
  return Q[tail - 1];
}

int main(){
  ios::sync_with_stdio(0);
  cin.tie(0);

  int c;
  cin >> c;

  while(c--){
    string input;
    cin >> input;

    if(input == "push"){
      int input2;
      cin >> input2;
      push(input2);
    }
    else if(input == "pop"){
      if (tail != head){
        cout << front() << "\n";
        pop();
      }
      else cout << -1 << "\n";
    }
    else if(input == "size"){
      cout << tail - head << "\n";
    }
    else if(input == "empty"){
      cout << (int) (tail == head) << "\n";
    }
    else if(input == "front"){
      if (tail != head) cout << front() << "\n";
      else cout << -1 << "\n";
    }
    else if(input == "back"){
      if (tail != head) cout << back() << "\n";
      else cout << -1 << "\n";
    }
  }
}
