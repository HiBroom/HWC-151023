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





// if (i < arr.Length - 1) Console.Write($"{arr[i]}, ");
//         else Console.Write($"{arr[i]}");


// Задача 63: Задайте значение N. Напишите программу, которая выведет
// все натуральные числа в промежутке от 1 до N.
// N = 5 -> "1, 2, 3, 4, 5"
// N = 6 -> "1, 2, 3, 4, 5, 6"

// Console.WriteLine("Input natural number: ");
// int number = Convert.ToInt32(Console.ReadLine());

// NaturalNumber(number);

// void NaturalNumber(int number)
// {
//     if (number == 0) return; // условие()
//     NaturalNumber(number - 1);//хвостовая рекурсия
//     Console.Write($"{number} "); // вывод метода
// }