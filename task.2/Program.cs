// Задача 2: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных индексах.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0

int a = ReadInt("Введите размерность массива -> ");
int b = ReadInt("Введите минимальное значение массива -> ");
int c = ReadInt("Введите максимальное значение массива -> ");

int[] array = GetRandomArray(a, b, c);
Console.WriteLine($"[{String.Join(",", array)}]");
Console.WriteLine($"Cумма отрицательных индексов в массиве - > {FindElement(array)}");


int FindElement(int[] array)
{
    int summ = 0;
    for (int count = 1; count < array.Length; count += 2)
    {
        summ = summ + array[count];
    }
    return summ;
}

// -------------------------------Общий метод-------------------------------------------
int ReadInt(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

// -------------------------------Общий метод-------------------------------------------
int[] GetRandomArray(int size, int minValue, int maxValue)
{
    int[] result = new int[size];
    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(minValue, maxValue + 1);
    }

    return result;
}