// Задача 68: Напишите программу вычисления функции Аккермана
// с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3->A(m, n) = 9
// m = 3, n = 2->A(m, n) = 29
Console.Write("Введите неотрицательное целое число m: ");
int m = int.Parse(Console.ReadLine()!);
Console.Write("Введите неотрицательное целое число n: ");
int n = int.Parse(Console.ReadLine()!);
Console.Write($"m = {m}, n = {n} -> A(m,n) = ");
FunctAkk(m, n);

void FunctAkk(int m, int n)
{
    Console.Write(Function(m, n));
}

int Function(int m, int n)
{
    if (m == 0)
        return n + 1;

    else if (n == 0 && m > 0)
        return Function(m - 1, 1);
    else
        return (Function(m - 1, Function(m, n - 1)));
}