// Задача 66: Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N. 
// Выполнить с помощью рекурсии.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30
Console.Write("Input number M: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Input number N: ");
int n = Convert.ToInt32(Console.ReadLine());

if (m <= 0)
{
    Console.Write($"Number {m} isn't natural");
    return;
}
else if (n <= 0)
{
    Console.Write($"Number {n} isn't natural");
    return;
}

Console.Write($"m = {m}; n = {n}. - > {RangeOfNumbers(m, n)}");

int RangeOfNumbers(int m, int n)
{
    int sum = 0;

    if (m > n)
    {
        sum += m + RangeOfNumbers(m - 1, n);
    }
    else if (m < n)
    {
        sum += n + RangeOfNumbers(m, n - 1);
    }
    else
    {
        return sum + m;
    }
    return sum;
}
