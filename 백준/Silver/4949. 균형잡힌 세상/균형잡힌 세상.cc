#include <bits/stdc++.h>
using namespace std;

bool isBalanced(const string& input) {
    stack<char> S;

    for (auto c : input)
    {
        if (c == '(' || c == '[')
        {
            S.push(c);
        }
        else if (c == ')')
        {
            if (S.empty() || S.top() != '(') return false;
            S.pop();
        }
        else if (c == ']')
        {
            if (S.empty() || S.top() != '[') return false;
            S.pop();
        }
    }
    return S.empty();
}

int main() {
    ios::sync_with_stdio(0);
    cin.tie(0);

    while (true) {
        string input;
        getline(cin, input);

        if (input == ".") break;

        if (isBalanced(input)) {
            cout << "yes\n";
        } else {
            cout << "no\n";
        }
    }
}
