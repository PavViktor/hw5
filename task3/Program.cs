/* Задача 38: Задайте массив вещественных чисел. 
Найдите разницу между максимальным и минимальным элементов массива. 
Не использовать готовые методы Min и Max
[3 7 22 2 78] -> 76 */

int size = 5;
int[] arr = new int[size];
FillArrayRandomNumbers(arr);
PrintArray(arr);

int max = arr[0];
int min = arr[0];

for (int i = 0; i < arr.Length; i++)
{
    if (arr[i] > max)
    {
        max = arr[i];
    }
    else if (arr[i] < min)
    {
        min = arr[i];
    }
}

Console.WriteLine($"min number: {min}");
Console.WriteLine($"max number: {max}");
Console.WriteLine($"вifference between max and min numbers: {max - min}");

void FillArrayRandomNumbers(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(1, 99);
    }
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}
