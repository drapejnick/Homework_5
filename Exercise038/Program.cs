// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

int[] GetArray(int size, int min, int max)
{
    int[] res = new int[size];
    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(min, max + 1);
        Console.Write($"{res[i]} ");
    }
    return res;
}

int[] array = GetArray(6, 10, 100);

int minValue = array[0];
for (int i = 1; i < array.Length; i++)
{
    if (array[i] < minValue)
        minValue = array[i];
}

int maxValue = array[0];
for (int i = 1; i < array.Length; i++)
{
    if (array[i] > maxValue)
        maxValue = array[i];
}

int sum = maxValue - minValue;

Console.WriteLine();
Console.Write($"Сумма элементов стоящих на нечетных позициях = {sum} ");

