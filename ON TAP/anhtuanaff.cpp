#include<iostream>
#include<string.h>
#include<stdlib.h>
using namespace std;
int a, b;
string encryption(string m) {
   string c = "";
   for (int i = 0; i < m.length(); i++) {
      if(m[i]!=' ')
         c = c + (char) ((((a * (m[i]-'A') ) + b) % 26) + 'A');
      else
         c += m[i];
   }
   return c;
}
string decryption(string c) {
   string m = "";
   int a_inverse = 0;
   int flag = 0;
   for (int i = 0; i < 26; i++) {
      flag = (a * i) % 26;
      if (flag == 1) {
         a_inverse = i;
      }
   }
   for (int i = 0; i < c.length(); i++) {
      if(c[i] != ' ')
         m = m + (char) (((a_inverse * ((c[i]+'A' - b)) % 26)) + 'A');
      else
         m += c[i];
   }
   return m;
}
int main(int argc, char **argv)
{
    cout << "Nhap a: "; cin >> a;
    cout << "Nhap b: "; cin >> b;
    string str1, str2;
    cout << "Nhap xau 1: ";
    cin >> str1;
    cout << "Nhap xau 2: ";
    cin >> str2;
    if (encryption(str1).compare(str2) == 0){
        cout << "Ban da nhap dung";
    } else cout << "Ban da nhap sai";

}
