#include <vector>
#include <iostream>

using namespace std;

string inputs;
int results[26];

void InputWords(){
  cin >> inputs;
}

void CheckWords(){
  for (int i = 0 ; i < inputs.length() ; i++){
    results[inputs[i] - 'a']++;
  }
}

void PrintResults(){
  for (int i = 0 ; i < 26 ; i++){
        cout << results[i] << ' ';
  }
}

int main(){
  inputs = "";
  fill(begin(results), end(results), 0);
  InputWords();
  CheckWords();
  PrintResults();
}