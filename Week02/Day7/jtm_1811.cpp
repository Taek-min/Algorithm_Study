#include <iostream>
#include <string>
#include <algorithm>
using namespace std;

bool compare(string a, string b) {
	if (a.length() < b.length()) {
		return 1;
	}
	else if (b.length() < a.length()) {
		return 0;
	}
	else {
		return a < b;
	}
}

int main()
{
	int n;
	cin >> n;
	string tmp;
	string* word = new string[n];

	for (int i = 0; i < n; i++)
	{
		cin >> word[i];
	}
	sort(word, word + n, compare);
	for (int i = 0; i < n; i++)
	{
		if (i > 0 && word[i] == word[i - 1])
			continue;
		cout << word[i] << endl;
	}
	delete[] word;
	return 0;
}// ±ò²Ä