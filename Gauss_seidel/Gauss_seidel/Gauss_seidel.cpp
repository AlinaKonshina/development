#include <iostream>
#include <fstream>
#include <cmath>
#include <iomanip>
#include <string>

using namespace std;
int main()
{
	double t = 0.0, h, tau;
	int N = 10, M;
	M = 2 * N * N;
	tau = 1.0 / M;
	h = 1.0 / N;
	double pi = 2 * asin(1);
	double tk = 5.0;
	double Norma = 0.0;
	double NORMA = 1.0;
	int c = 1;
	int q = 0;
	double x = 0.0;
	int nomer = 0;

	double** T1 = new double* [N + 1];
	for (int i = 0; i < N + 1; i++) {
		T1[i] = new double[N + 1];
	}
	double** T2 = new double* [N + 1];
	for (int i = 0; i < N + 1; i++) {
		T2[i] = new double[N + 1];
	}
	double** T3 = new double* [N + 1];
	for (int i = 0; i < N + 1; i++) {
		T3[i] = new double[N + 1];
	}
	double** T4 = new double* [N + 1];

	ofstream file;
	file.open("res1.txt");

	for (int i = 0; i < N + 1; i++) {
		for (int j = 0; j < N + 1; j++) {
			T1[i][j] = sin(pi * i * h * j * h * 0.5);
		}
	}//заполняем первый слой в свободном виде

	for (int i = 0; i < N + 1; i++) {
		for (int j = 0; j < N + 1; j++) {
			file << setw(10) << T1[i][j] << " ";
		} file << endl;
	}//вывод в файл первого слоя

	while ((tau * c) < tk) {

		while (NORMA > 0.001) {

			for (int ii = 0; ii < N + 1; ii++) {
				T2[0][ii] = 0.0;
				T2[N][ii] = 1.0;
			}
			for (int ii = 1; ii < N; ii++) {
				T2[ii][0] = 0.0;
				T2[ii][N] = 1.0;
			}//заполняем границы

			if (q == 0) {
				for (int i = 1; i < N; i++) {
					for (int j = 1; j < N; j++) {
						T2[i][j] = (T1[i][j] / tau + (T1[i + 1][j] + T2[i - 1][j] + T1[i][j + 1] + T2[i][j - 1]) / (h * h)) / (1 / tau + 4 / (h * h));
					}
				}

				q++;
			}
			else {
				for (int i = 1; i < N; i++) {
					for (int j = 1; j < N; j++) {
						T2[i][j] = (T1[i][j] / tau + (T3[i + 1][j] + T2[i - 1][j] + T3[i][j + 1] + T2[i][j - 1]) / (h * h)) / (1 / tau + 4 / (h * h));
					}
				}
			}
			for (int i = 0; i < N + 1; i++) {
				for (int j = 0; j < N + 1; j++) {
					if (i == 0 || j == 0 || i == N || j == N) {
						Norma += 0.0;
					}
					else {
						Norma += ((T2[i][j] - T1[i][j]) / tau - (T2[i + 1][j] + T2[i - 1][j] + T2[i][j + 1] + T2[i][j - 1] - 4 * T2[i][j]) / (h * h)) * ((T2[i][j] - T1[i][j]) / tau - (T2[i + 1][j] + T2[i - 1][j] + T2[i][j + 1] + T2[i][j - 1] - 4 * T2[i][j]) / (h * h));
					}
				}
			}

			NORMA = sqrt(Norma);

			//Вывод невязки и номера итерации (при необходимости)
			/*
			if (tau * c * 100 == 10.000000) {
				nomer = nomer + 1;
				ofstream NEV;
				NEV.open("NEV1.txt");
				NEV << setw(10) << NORMA << " ";

				ofstream NOMu;
				NOMu.open("NOMu1.txt");
				NOMu << nomer << " ";
				NEV.close();
				NOMu.close();
			}
			*/

			Norma = 0.0;
			T4 = T2;
			T2 = T3;
			T3 = T4;
		}

		//вывод в файл основных значений(на определенных слоях)
		int type = tau * c * 10;

		if (((tau * c * 10 - type) == 0)) {
			ofstream res;
			res.open("res" + to_string(c * tau * 100) + ".txt");
			res << setw(10) << " ";
			for (int a = 0; a < N + 1; a++) {
				for (int z = 0; z < N + 1; z++) {
					res << setw(10) << T1[a][z] << " ";
				}
				res << endl;
			}
			res.close();
		}

		T4 = T2;
		T2 = T1;
		T1 = T4;
		q = 0;
		c++;
		NORMA = 10.0;
	}

	//очищение массивов
	for (int i = 0; i < N + 1; i++) {
		delete[]T1[i];
	}
	for (int i = 0; i < N + 1; i++) {
		delete[]T2[i];
	}
	for (int i = 0; i < N + 1; i++) {
		delete[]T3[i];
	}
}