// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

Console.Write("Введите количество элементов массива: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] array = new int[size];

for (int i = 1; i < size; i++)
{
    array[i] = new Random().Next(1, 20);
}
int numberUneven(int[] array)
{
    int sum = 0;
    int i = 0;
    while (i < array.Length)
    {
        sum += array[i];
        i += 2;
    }
    return sum;
}
Console.WriteLine($"Массив: [ {string.Join("; ", array)} ]");
Console.WriteLine($"Сумма чисел на нечетных позициях: [ {string.Join("; ", numberUneven(array))} ]");
