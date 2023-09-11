#include <iostream>
#include <string>
#include <vector>
#include<bits/stdc++.h>
using namespace std;

int char_to_num(char c) {
    return c - 'A';
}

char num_to_char(int num) {
    return num + 'A';
}

string hill_cipher(string plaintext, vector<vector<int>> key) {
    string ciphertext = "";
    int M = 26;

    int n = key.size();
    int plaintext_len = plaintext.length();
    while (plaintext_len % n != 0) {
        plaintext += 'X';
        plaintext_len++;
    }

    for (int i = 0; i < plaintext_len; i += n) {
        vector<int> block(n);
        for (int j = 0; j < n; j++) {
            block[j] = char_to_num(plaintext[i+j]);
        }
        for (int j = 0; j < n; j++) {
            int sum = 0;
            for (int k = 0; k < n; k++) {
                sum += key[j][k] * block[k];
            }
            ciphertext += num_to_char(sum % M);
        }
    }

    return ciphertext;
}

string hill_decipher(string ciphertext, vector<vector<int>> key) {
    string plaintext = "";
    int M = 26;

    int det = key[0][0] * key[1][1] - key[0][1] * key[1][0];
    while (det < 0) {
        det += M;
    }
    det %= M;

    int det_inv;
    for (int i = 0; i < M; i++) {
        if ((i * det) % M == 1) {
            det_inv = i;
            break;
        }
    }

    vector<vector<int>> key_inv(2, vector<int>(2));
    key_inv[0][0] = key[1][1] * det_inv % M;
    key_inv[0][1] = (-key[0][1] + M) % M * det_inv % M;
    key_inv[1][0] = (-key[1][0] + M) % M * det_inv % M;
    key_inv[1][1] = key[0][0] * det_inv % M;

    int n = key.size();
    int ciphertext_len = ciphertext.length();
    for (int i = 0; i < ciphertext_len; i += n) {
        vector<int> block(n);
        for (int j = 0; j < n; j++) {
            block[j] = char_to_num(ciphertext[i+j]);
        }
        for (int j = 0; j < n; j++) {
            int sum = 0;
            for (int k = 0; k < n; k++) {
                sum += key_inv[j][k] * block[k];
            }
            plaintext += num_to_char(sum % M);
        }
    }

    return plaintext;
}

string hill_decipher(string ciphertext, vector<vector<int>> key) {
    string plaintext = "";
    int M = 26;

    int det = key[0][0] * key[1][1] - key[0][1] * key[1][0];
    while (det < 0) {
        det += M;
    }
    det %= M;

    int det_inv;
    for (int i = 0; i < M; i++) {
        if ((i * det) % M == 1) {
            det_inv = i;
            break;
        }
    }

    vector<vector<int>> key_inv(2, vector<int>(2));
    key_inv[0][0] = key[1][1] * det_inv % M;
    key_inv[0][1] = (-key[0][1] + M) % M * det_inv % M;
    key_inv[1][0] = (-key[1][0] + M) % M * det_inv % M;
    key_inv[1][1] = key[0][0] * det_inv % M;

    int n = key.size();
    int ciphertext_len = ciphertext.length();
    for (int i = 0; i < ciphertext_len; i += n) {
        vector<int> block(n);
        for (int j = 0; j < n; j++) {
            block[j] = char_to_num(ciphertext[i+j]);
        }
        for (int j = 0; j < n; j++) {
            int sum = 0;
            for (int k = 0; k < n; k++) {
                sum += key_inv[j][k] * block[k];
            }
            plaintext += num_to_char(sum % M);
        }
    }

    return plaintext;
}

bool is_hill_cipher(string plaintext, string ciphertext, vector<vector<int>> key) {
    return hill_decipher(ciphertext, key) == plaintext;
}

int main() {
    int a, b, c, d;
    cout << "Nhap a: "; cin >> a;
    cout << "Nhap b: "; cin >> b;
    cout << "Nhap c: "; cin >> c;
    cout << "Nhap d: "; cin >> d;
    vector<vector<int>> key = {{a, c}, {b, d}};

    string str1;
    cout << "Nhap xau 1: ";
    cin >> str1;
    string str2;
    cout << "Nhap xau 2: ";
    cin >> str2;
    if (is_hill_cipher(str1, str2, key)) {
        cout << "Ban da nhap dung." << endl;
    } else {
        cout << "Ban da nhap sai." << endl;
    }

    return 0;
}
