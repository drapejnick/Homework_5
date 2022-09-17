// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
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

int[] array = GetArray(6, -10, 10);
int index = 0;
int n = 0;
int sum = 0;

while (index < array.Length)
{
    if (n % 2 != 0)
    {
        sum = sum + array[n];
    }
    index++;
    n++;
}

Console.WriteLine();
Console.Write($"Сумма элементов стоящих на нечетных позициях = {sum} ");