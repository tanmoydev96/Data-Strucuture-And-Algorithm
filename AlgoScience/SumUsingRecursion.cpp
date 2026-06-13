#include <bits/stdc++.h>
using namespace std;
using ll = long long;
#define all(x) (x).begin(), (x).end()

void loop_using_recursion(int i, int n, int *sum)
{
	if(i == n+1) return;
	*sum += i;
	loop_using_recursion(i+1,n,sum);

}

int main() {
	ios_base::sync_with_stdio(false);
	cin.tie(nullptr);
	int sum = 0;
	int n;
	cin >> n;
	loop_using_recursion(1,n,&sum);
	cout<<sum<<"\n";
}
