// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76

Console.Write("Введите количество чисел в массиве: ");
int size = Convert.ToInt32(Console.ReadLine());
double[] array = new double[size];

void massive(int size)
{
    Random gen = new Random();
    for (int i = 0; i < size; i++)
    {
        array[i] = gen.Next(1, 100) + gen.NextDouble();
        Console.Write($"[{array[i]:F2}] ");
    }
}

double diffInNumbers(double[] array)
{
    double min = array[0];
    double max = array[0];
    int i = 1;
    while (i < array.Length)
    {
        if (max < array[i])
            max = array[i];
        if (min > array[i])
            min = array[i];
        i += 1;
    }
    return max - min;
}
massive(size);
Console.Write($"\nРазница между максимальным и минимальным элементов массива: {Math.Round(diffInNumbers(array)):F2}");
