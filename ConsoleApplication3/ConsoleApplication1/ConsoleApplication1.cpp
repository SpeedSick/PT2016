#include<cstdio>

#define mp make_pair
#define pb push_back
#define F first
#define S second
#define fo(i, n) for(int i = 1; i <= n; ++i)

using namespace std;

int a[100100];

int main()
{
	int n;
	scanf("%d", &n);
	fo(i, n)
		scanf("%d", a + i);
	fo(i, n)
		printf("%d ", a + i);
    return 0;
}

