// Задача 3: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.(https://learn.microsoft.com/ru-ru/dotnet/api/system.random.nextdouble?view=net-7.0)

// [3, 7.4, 22.3, 2, 78] -> 76

// double a = ReadInt("Введите размерность массива -> ");
// double b = ReadInt("Введите минимальное значение массива -> ");
// double c = ReadInt("Введите максимальное значение массива -> ");

double[] array = GetRandomArray(3, 23.4 , 85.5);
Console.WriteLine($"[{String.Join(",", array)}]");
// Console.WriteLine($"Cумма отрицательных индексов в массиве - > {FindElement(array)}");


// int FindElement(double[] array)
// {
//     double summ = 0;
//     for (int count = 1; count < array.Length; count += 2)
//     {
//         summ = summ + array[count];
//     }
//     return summ;
// }

// -------------------------------Общий метод-------------------------------------------
// int ReadInt(string text)
// {
//     Console.Write(text);
//     return Convert.ToInt32(Console.ReadLine());
// }

// -------------------------------Общий метод-------------------------------------------
double[] GetRandomArray(double size, double minValue, double maxValue)
{
    double[] result = new double[size];
    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().NextDouble(minValue, maxValue);
    }

    return result;
}