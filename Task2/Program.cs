﻿/* Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30 */



Console.Write("Введите значение M: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите значение N: ");
int n = Convert.ToInt32(Console.ReadLine());

int sum = 0;

for (int i = m; i <= n; i++)
{
    sum += i;
}

Console.WriteLine("Сумма натуральных чисел в промежутке от {0} до {1} равна {2}", m, n, sum);

/* Введите значение M: 1
Введите значение N: 15
Сумма натуральных чисел в промежутке от 1 до 15 равна 120
Введите значение M: 4
Введите значение N: 8
Сумма натуральных чисел в промежутке от 4 до 8 равна 30 */