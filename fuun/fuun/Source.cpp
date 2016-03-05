#include<stdio.h>
#include<cstring>
#include<math.h>
#include<cstdio>
#include<cmath>
#include<map>
#include<queue>
#include<iostream>
#include<vector>
#include<cstdlib>
#include<set>
#include<algorithm>

using namespace std;

typedef pair <int, int> pii;
typedef pair <pii, pii> ppi;
#define mp make_pair

int n, m, fix, fiy, sex, sey, bad[51][51];
char ch;
int EQ;
int was[51][51][51][51], dp[51][51][51][51];
int eq = 0, ans = (int)1e9;
int dx[] = { 0,0,-1,1 };
int dy[] = { 1,-1,0,0 };

inline void bfs(int fx, int fy, int sx, int sy)
{ 
	queue <ppi> q;
	q.push(mp(mp(fx, fy), mp(sx, sy)));
	was[fx][fy][sx][sy] = 1;
	while (!q.empty())
	{
		ppi v = q.front();
		q.pop();
		int fx = v.first.first, fy = v.first.second, sx = v.second.first, sy = v.second.second;
		for (int i = 0; i < 4; ++i)
		{
			int tofx = (fx + dx[i]+n) % n, tosx = (sx + dx[i]+n) % n;
			int tofy = (fy + dy[i]+m) % m, tosy = (sy + dy[i]+m) % m;
			if (bad[tofx][tofy] != 2 && bad[tosx][tosy] != 2)
			{
				if (bad[tofx][tofy] == 1) tofx = fx, tofy = fy;
				if (bad[tosx][tosy] == 1) tosx = sx, tosy = sy;
				if (!was[tofx][tofy][tosx][tosy])
				{
					was[tofx][tofy][tosx][tosy] = 1;
					dp[tofx][tofy][tosx][tosy] = dp[fx][fy][sx][sy] + 1;
					q.push(mp(mp(tofx, tofy), mp(tosx, tosy)));
				}
			}
		}
	}
}


int main()
{
	cin >> n >> m;
	for (int i = 0; i < n; ++i)
		for (int j = 0; j < m; ++j)
		{
			cin >> ch;
			if (ch == 'S')
			{
				if (!EQ) EQ = 1, fix = i, fiy = j;
				else sex = i, sey = j;
			}
			else if (ch == 'P')
				bad[i][j] = 1;
			else if (ch == 'W')
				bad[i][j] = 2;
		}
	bfs(fix, fiy, sex, sey);
	for (int i = 0; i < n; ++i)
		for (int j = 0; j < m; ++j)
			if (was[i][j][i][j]) ans = min(ans, dp[i][j][i][j]);
	cout << (ans == 1e9 ? -1 : ans);
	return 0;
}