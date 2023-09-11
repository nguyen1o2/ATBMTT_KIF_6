#include<iostream>
#include<cmath>
using namespace std;

int main() {
    int a, b, c, d;
    int det, det_inv;
    int M = 26;
    int K_inv[2][2];

    cout << "Nhap ma tran khoa K = \n";
    cout << "a = ";
    cin >> a;
    cout << "b = ";
    cin >> b;
    cout << "c = ";
    cin >> c;
    cout << "d = ";
    cin >> d;

    det = (a*d - b*c) % M;

    for (int i = 0; i < M; i++) {
        if ((i * det) % M == 1) {
            det_inv = i;
            break;
        }
    }

    K_inv[0][0] = det_inv * d % M;
    K_inv[0][1] = (-det_inv * b + M) % M;
    K_inv[1][0] = (-det_inv * c + M) % M;
    K_inv[1][1] = det_inv * a % M;

    cout << "Ma tran khoa giai ma K^-1 = \n";
    cout << K_inv[0][0] << " " << K_inv[0][1] << "\n";
    cout << K_inv[1][0] << " " << K_inv[1][1] << "\n";

    return 0;
}
