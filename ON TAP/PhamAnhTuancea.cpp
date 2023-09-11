#include<bits/stdc++.h>
using namespace std;

string encrypt(string plaintext, int key)
{
    string ciphertext = "";
    for (int i = 0; i < plaintext.length(); i++)
    {
        char c = plaintext[i];
        if (isalpha(c))
        {
            c = toupper(c);
            c = (c - 65 + key) % 26 + 65;
        }
        ciphertext += c;
    }
    return ciphertext;
}

string encrypt(string plaintext, int key)
{
    string ciphertext = "";
    for (int i = 0; i < plaintext.length(); i++)
    {
        char c = plaintext[i];
        if (isalpha(c))
        {
            c = toupper(c);
            c = (c - 65 + key) % 26 + 65;
        }
        ciphertext += c;
    }
    return ciphertext;
}
