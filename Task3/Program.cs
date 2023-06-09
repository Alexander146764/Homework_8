﻿/* Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29 */

/// <summary>
/// функция Аккермана
/// </summary>
/// <param name="m">первое число, больше или равно нулю </param>
/// <param name="n">второе число, больше или равно нулю</param>
/// <returns>вычисление функции</returns>
static int Ackermann(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if (n == 0)
    {
        return Ackermann(m - 1, 1);
    }
    else
    {
        return Ackermann(m - 1, Ackermann(m, n - 1));
    }
}

Console.Write("Введите значение m: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите значение n: ");
int n = Convert.ToInt32(Console.ReadLine());

int result = Ackermann(m, n);

Console.WriteLine("Результат функции Аккермана для A({0},{1}) = {2}", m, n, result);

/* Введите значение m: 2
   Введите значение n: 3
   Результат функции Аккермана для A(2,3)=9
   Введите значение m: 3
   Введите значение n: 2
   Результат функции Аккермана для A(3,2) = 29 */