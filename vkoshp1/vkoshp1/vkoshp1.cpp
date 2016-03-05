#include<iostream>
#include<cstdio>
#include<algorithm>


using namespace std;

int main()
{
	int n, l, w, x, y, a;
	scanf("%d%d%d%d%d%d", &n, &l, &w, &x, &y, &a);
    
	int L = 0, R = n;
	int InOneRow = l / x;
	int CntOfRows = (n + InOneRow - 1) / InOneRow;
	int width = CntOfRows * y;
	width = w - width;
	
	printf("%d", width / a * 2 * InOneRow);
	
	return 0;
}

