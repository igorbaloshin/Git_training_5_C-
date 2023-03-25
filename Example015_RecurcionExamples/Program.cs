using System;
using static System.Console;

Clear();

string NumbersFor(int a, int b)
{
    string result = String.Empty;
    for (int i = a; i <= b; i++)
    {
        result += $"{i} ";
    }
    return result;
}

string NumbersRec(int a, int b)
{
    if (a <= b)
        return $"{a} " + NumbersRec(a + 1, b);
    else return String.Empty;
}

WriteLine(NumbersFor(1, 10));
WriteLine(NumbersRec(1, 10));

//--------------------------------------------------------
int SumFor(int n)
{
    int result = 0;
    for (int i = 0; i <= n; i++)
    {
        result += i;
    }
    return result;
}

int SumRec(int n)
{
    if (n == 0) return 0;
    else return n + SumRec(n - 1);
}

WriteLine(SumFor(10));
WriteLine(SumRec(10));
//-------------------------------------------------------
int FactorialFor(int n)
{
    int result = 1;
    for (int i = 1; i <= n; i++)
    {
        result *= i;
    }
    return result;
}

int FactorialRec(int n)
{
    if (n == 1) return 1;
    else return n * FactorialRec(n - 1);
}

WriteLine(FactorialFor(10));
WriteLine(FactorialRec(10));
//------------------------------------------------
int PowerFor(int a, int n)
{
    int result = 1;
    for (int i = 1; i <= n; i++)
    {
        result *= a;
    }
    return result;
}

int PowerRec(int a, int n)
{
    if (n == 0) return 1;
    else return a * PowerRec(a, n - 1);
}

WriteLine(PowerFor(2, 10));
WriteLine(PowerRec(2, 10));
//--------------------------------------------

double fFor = 0;
double fRec = 0;
double fRec_M = 0;

double FibonacciFor(int n)
{
    fFor++;
    if (n == 1 || n == 2)
        return 1;
    else
    {
        double result = 1;
        double f0 = 1;
        double f1 = 1;

        for (int i = 3; i <= n; i++)
        {
            result = f0 + f1;

            f0 = f1;
            f1 = result;
            fFor++;
        }
        return result;
    }
}

double FibonacciRec(int n)
{
    fRec++;
    if (n == 1 || n == 2)
        return 1;
    else
        return FibonacciRec(n - 1) + FibonacciRec(n - 2);
}


double FibonacciRec_M(double first, double second, int n)
{
    fRec_M++;
	if(n == 1 || n == 2)
		return 1;
	else if (n == 3)
		return first + second;
	else
		return FibonacciRec_M(second, first + second, n - 1);
 
}
// for(int i = 1; i <= 40; i++)
// {
//     Console.WriteLine($"{ i } Fibonacci_M = {Fibonacci_M(1, 1, i)}");
// }

DateTime dt = DateTime.Now;

for (int i = 1; i <= 43; i++)
{
    Console.WriteLine($"{i, 3:F0} \t FibonacciFor = {FibonacciFor(i), 23:F0} \t fFor = {fFor, 10:F0}"); // "\t" табуляция  
    fFor = 0;
}
WriteLine((DateTime.Now - dt).TotalMilliseconds);

dt = DateTime.Now;

for (int i = 1; i <= 43; i++)
{
    Console.WriteLine($"{i, 3:F0} \t FibonacciRec = {FibonacciRec(i), 23:F0} \t fRec = {fRec, 10:F0}");//.ToString("### ### ###"), 15}");
    fRec = 0;
}
WriteLine((DateTime.Now - dt).TotalMilliseconds);

dt =DateTime.Now;
for (int i = 1; i <= 43; i++)
{
    Console.WriteLine($"{i, 3:F0} \t FibonacciRec_M = {FibonacciRec_M(1, 1, i), 23:F0} \t fFor = {fRec_M, 10:F0}"); // "\t" табуляция  
    fFor = 0;
}
WriteLine((DateTime.Now - dt).TotalMilliseconds);
