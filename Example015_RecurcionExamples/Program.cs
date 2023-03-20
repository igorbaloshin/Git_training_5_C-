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
double fRec = 0;
double fFor = 0;

double FibonacciRec(int n)
{
    fRec++;
    if (n == 1 || n == 2)
        return 1;
    else
        return FibonacciRec(n - 1) + FibonacciRec(n - 2);
}

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

DateTime dt = DateTime.Now;

for (int i = 1; i <= 45; i++)
{
    Console.WriteLine($"{i} FibonacciFor = {FibonacciFor(i)} fFor = {fFor, 15:F0}");
    fFor = 0;
}
WriteLine((DateTime.Now - dt).TotalMilliseconds);

dt = DateTime.Now;

for (int i = 1; i <= 45; i++)
{
    Console.WriteLine($"{i} FibonacciRec = {FibonacciRec(i)} fRec = {fRec, 15:F0}");//.ToString("### ### ###"), 15}");
    fRec = 0;
}
WriteLine((DateTime.Now - dt).TotalMilliseconds);