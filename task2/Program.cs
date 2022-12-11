/* Задача 36: Задайте одномерный массив, заполненный случайными числами. 
Найдите сумму элементов, стоящих на нечётных индексах.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0 */

int size = new Random().Next(4,6);
int[] numbers = new int[size];
FillArrayRandomNumbers(numbers);
PrintArray(numbers);
int sum = 0;

for (int i = 1; i < numbers.Length; i += 2)
    sum = sum + numbers[i];

Console.WriteLine($"there is {numbers.Length} numbers, sum of elements of odd indexes = {sum}");

void FillArrayRandomNumbers(int[] numbers)
{
    for (int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = new Random().Next(1, 10);
    }
}
void PrintArray(int[] numbers)
{
    for (int i = 0; i < numbers.Length; i++)
    {
        Console.Write(numbers[i] + " ");
    }
    Console.WriteLine();
}
