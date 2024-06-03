#include <bits/stdc++.h>
using namespace std;

const int MX = 1000005;
int DQ[MX * 2 + 1];
int head = MX, tail = MX;

void push_front(int x){
  DQ[--head] = x;
}

void push_back(int x){
  DQ[tail++] = x;
}

void pop_front(){
  head++;
}

void pop_back(){
  tail--;
}

int front(){
  return DQ[head];
}

int back(){
  return DQ[tail - 1];
}

bool empty(){
  return (head == tail);
}

int main(){
  ios::sync_with_stdio(0);
  cin.tie(0);

  int c;
  cin >> c;

  while(c--){
    string i;
    cin >> i;

    if (i == "push_front"){
      int i2;
      cin >> i2;

      push_front(i2);
    }
    else if (i == "push_back"){
      int i2;
      cin >> i2;
      
      push_back(i2);
    }
    else if (i == "pop_front"){
       if (!empty()){
        cout << front() << "\n";
        pop_front();
      }
      else cout << -1 << "\n";
    }
    else if (i == "pop_back"){
      if (!empty()){
        cout << back() << "\n";
        pop_back();
      }
      else cout << -1 << "\n";
    }
    else if (i == "size"){
      cout << tail - head << "\n";
    }
    else if (i == "empty"){
      cout << (int) empty() << "\n";
    }
    else if (i == "front"){
      if (!empty()) cout << front() << "\n";
      else cout << -1 << "\n";
    }
    else if (i == "back"){
      if (!empty()) cout << back() << "\n";
      else cout << -1 << "\n";
    }
  }
}