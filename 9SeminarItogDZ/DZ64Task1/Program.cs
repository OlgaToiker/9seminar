// Задача 64: Задайте значение N. Напишите программу,
// которая выведет все натуральные числа в промежутке
// от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

Console.Write("Введите натуральное число N больше 1: ");
int number = int.Parse(Console.ReadLine()!);
if (number <= 0) Console.Write($"{number} - не натуральное число ");
Console.Write($"N = {number} -> ");
Numbers(number);

void Numbers(int n)
{
    if (n <= 0)
    return;
    if (n == 1) Console.Write($"{n}");
    if (n > 1) Console.Write($"{n}, ");
    Numbers(n - 1);
}