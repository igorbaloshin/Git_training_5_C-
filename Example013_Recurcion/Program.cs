Console.Clear();
// Функция факториал
double Factorial(int n)
{
    if(n == 1)
    return 1;
    else
    return n * Factorial(n - 1);
}
for(int i =1; i <= 45; i++)
{
    Console.WriteLine($"{i} ! = {Factorial(i)}");
}

// Функция Фибоначи

double Fibonacci(int n)
{
    if(n == 1 || n == 2 )
    return 1;
    else
    return Fibonacci(n - 1) + Fibonacci(n - 2);
}

for(int i = 1; i <= 40; i++)
{
    Console.WriteLine($"{ i } Fibonacci = {Fibonacci(i)}");
}

int Fibonacci_M(int first, int second, int n)
{
	if(n == 1 || n == 2)
		return 1;
	else if (n == 3)
		return first + second;
	else
		return Fibonacci_M(second, first + second, n - 1);
 
}
for(int i = 1; i <= 40; i++)
{
    Console.WriteLine($"{ i } Fibonacci_M = {Fibonacci_M(1, 1, i)}");
}