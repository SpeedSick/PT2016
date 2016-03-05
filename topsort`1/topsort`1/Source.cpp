#include<iostream>
#include<cstdio>
#include<algorithm>
#include<vector>

using namespace std;

vector <int> g[100100];
int used[100100];
int pos[100100];
vector <int> order;

inline void dfs(int v)
{
	used[v] = 1;
	for (int i = 0; i < g[v].size(); ++i)
		if (!used[g[v][i]]) dfs(g[v][i]);
	order.push_back(v);
}

int main()
{
	freopen("topsort.in", "r", stdin);
	freopen("topsort.out", "w", stdout);
	int n, m;
	scanf("%d%d", &n, &m);
	for (int i = 1; i <= m; ++i)
	{
		int u, v;
		scanf("%d%d", &u, &v);
		g[u].push_back(v);
	}
	for (int i = 1; i <= n; ++i)
		if (!used[i]) dfs(i);
	reverse(order.begin(), order.end());
	for (int i = 0; i < order.size(); ++i)
		pos[order[i]] = i;
	for (int i = 1; i <= n; ++i)
		for (int j = 0; j < g[i].size(); ++j)
		{
			int to = g[i][j];
		//	cerr << i << ' ' << to << ' ' << pos[to] << ' ' << pos[i] << endl;
			if (pos[to] < pos[i]) return puts("-1"), 0;
		}
	for (int i = 0; i < order.size(); ++i)
		printf("%d ", order[i]);
	return 0;
}