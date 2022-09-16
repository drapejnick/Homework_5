﻿// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int[] GetArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size];
    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1);
        Console.Write($"{res[i]} ");
    }
    return res;
}

int sum = 0;
int[] array = GetArray(4, 1, 20);

foreach (int el in array)
{
    if (el % 2 == 1)
        sum += el;
}
Console.WriteLine();
Console.Write($"Сумма элементов стоящих на нечетных позициях = {sum} ");