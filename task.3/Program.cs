// Задача 3: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.(https://learn.microsoft.com/ru-ru/dotnet/api/system.random.nextdouble?view=net-7.0)

// [3, 7.4, 22.3, 2, 78] -> 76

double[] doubleArray = GetRandomArray(6, 0, 99);
Console.WriteLine($"[{String.Join(" ", doubleArray)}]");

Console.WriteLine(GetResultDiff(doubleArray));

double GetResultDiff(double[] array)
{
    double min = array[0];
    double max = array[0];
    foreach (var item in array)
    {
        if(min > item) min = item;
        if(max < item) max = item;
    }
    return max - min;
}
//------------------общий метод---------------------

double[] GetRandomArray(int size, int minValue, int maxValue)
{
    double[] result = new double[size];
    for (int i = 0; i < size; i++)
    {
        result[i] = Math.Round(new Random().NextDouble() + new Random().Next( maxValue - minValue), 2);
    }

    return result;
}