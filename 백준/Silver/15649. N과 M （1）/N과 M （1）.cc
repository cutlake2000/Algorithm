#include <bits/stdc++.h>
using namespace std;

int n, m;
bool isVisited[9];
vector<int> result;

void BackTrack(int depth) {
    if (depth == m) {
        for(auto r : result) {
            cout << r << " ";
        }
        cout << '\n';
        return;
    }

    for (int i = 1; i <= n; i++) {
        if (!isVisited[i]) {
            isVisited[i] = true;
            result.push_back(i);

            BackTrack(depth + 1);

            isVisited[i] = false;
            result.pop_back();
        }
    }
}

int main() {
    ios::sync_with_stdio(0);
    cin.tie(0);

    cin >> n >> m;

    BackTrack(0);
}