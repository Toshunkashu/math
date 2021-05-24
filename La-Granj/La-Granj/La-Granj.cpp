// by Toshunkashu

#include <iostream>
#include <cmath>
using namespace std;

int N;

class x
{
public:
	int power=NULL;
	double coef=NULL;
	x(){}
	x(double koef, int pow) { coef = koef; power = pow; };
	~x() { }
	x operator+(const x&);
	x operator*(const x&);
	x operator/(const x&);
};

x x::operator+(const x& X)
{
	if (power == X.power) return x(coef + X.coef, power);
	else return x(coef,power);
}
x x::operator*(const x& X)
{
	return x(coef * X.coef, power + X.power);
}
x x::operator/(const x& X)
{
	return x(coef / X.coef, power - X.power);
}

double rounding(double ch, int znach)
{
	int nul = 1;
	for (int i = 0; i < znach; i++) nul *= 10;
	if (ch > 0) return floor(ch * nul + 0.5) / nul;
	else return ceil(ch * nul - 0.5) / nul;
}

double function(x* func, double X)
{
	double Y = 0;
	for (int i = 0; i < N; i++)
	{
		Y += pow(X, func[i].power) * func[i].coef;
	}
	return Y;
}

int main()
{
	setlocale(LC_ALL, "Rus");
	
	cout << "Введiть розмiр таблицi= ";
	cin >> N;
	double** XY = new double* [2];
	XY[0] = new double[N];
	XY[1] = new double[N];

	cout << "\nВведiть " << N << " значень Х:\n";
	for (int i = 0; i < N; i++)
	{
		cout << "[" << i + 1 << "] -> ";
		cin >> XY[0][i];
	}
	cout << "\nВведiть " << N << " значень Y:\n";
	for (int i = 0; i < N; i++)
	{
		cout << "[" << i + 1 << "] -> ";
		cin >> XY[1][i];
	}


	//operator
	x** dodanki = new x * [N];
	for (int i = 0; i < N; i++) dodanki[i] = new x[pow(2, N - 1)];
	double* znam = new double[N];
	for (int i = 0; i < N; i++)
	{
		znam[i] = 1;
	}
	x mnoj;

	for (int i = 0; i < N; i++)//доданки (дроби)
	{
		for (int j = 0, n = 0, m = 2; j < N - 1; j++)//вираховування дробу без у(n)
		{
		drob:;
			if (j + n != i)
			{
				mnoj = x(-1 * (XY[0][j + n]), 0);
				//chis
				if (j == 0) {
					dodanki[i][0] = x(1, 1); dodanki[i][1] = x(-1 * (XY[0][j + n]), 0);
				}
				else
				{
					for (int z = m; z < m * 2; z++)
					{
						dodanki[i][z] = dodanki[i][z - m] * mnoj;
					}
					for (int z = 0; z < m; z++)
					{
						dodanki[i][z] = dodanki[i][z] * x(1, 1);
					}
					m *= 2;
				}
				//znam
				znam[i] *= (XY[0][i] - XY[0][j + n]);
			}
			else { n++; goto drob; }
		}

			for (int j = 0; j < pow(2, N - 1); j++)
			{
				dodanki[i][j].coef = (dodanki[i][j].coef * XY[1][i]) / znam[i];
		    }
		
	}
	
	x* formula = new x[N];
	for (int i = 0; i < N; i++) formula[i] = x(0, i);
	for (int s = 0; s < N; s++)
	{
		for (int i = 0; i < N; i++)
		{
			for (int j = 0; j < pow(2, N - 1); j++)
			{
				formula[s] = formula[s] + dodanki[i][j];
			}
		}
		//formula[s].coef = rounding(formula[s].coef, 5);
	}

	cout << "\n\n\n--------------\n";
	cout << "f(x) = ";
	for (int i = N-1; i >= 0; i--)
	{
		if (i != N - 1 && formula[i].coef > 0) cout << "+";
		cout << rounding(formula[i].coef, 5) << "*x^" << formula[i].power << " ";
	}
	cout << "\n\n Пiдставте х.";
	double test_x;
test:;
	cout << "\n--> ";
	cin >> test_x;
	cout<<"\nf(x) = "<< rounding(function(formula, test_x),5);
	goto test;
}