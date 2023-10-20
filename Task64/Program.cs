// Задача 64: Задайте значение N. Напишите программу, 
// которая выведет все натуральные числа в промежутке от N до 1. 
// Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
Console.Write("Input number N: ");
int N = Convert.ToInt32(Console.ReadLine());


if(N < 1)
{
    Console.Write($"N = {N} ->It's not natural number!");
    return;
}

Console.Write($"N = {N} -> ");
NaturalNumbers(N);

void NaturalNumbers(int N)
{

    if (N == 1) 
    {
         Console.Write($"{N}");
         return;
    }
    else
    {
        Console.Write($"{N}, ");
        NaturalNumbers(N - 1);
    }
}
