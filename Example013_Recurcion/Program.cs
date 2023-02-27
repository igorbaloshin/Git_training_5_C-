Console.Clear();
// Функция факториал
double Factorial(int n)
{
    if(n == 1)
    return 1;
    else
    return n * Factorial(n - 1);
}
for(int i =1; i <= 30; i++)
{
    Console.WriteLine($"{i} ! = {Factorial(i)}");
}

// Функция Фибоначи

double Fibonacci(int n)
{
    if(n == 1 || n == 2)
    return 1;
    else
    return Fibonacci(n - 1) + Fibonacci(n - 2);
}

for(int i = 1; i <= 40; i++)
{
    Console.WriteLine($"{ i } Fibonacci = {Fibonacci(i)}");
}