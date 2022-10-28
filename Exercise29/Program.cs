// Задача 29: 
// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

Console.WriteLine("Введите диапазон чисел для создания массива:");
Console.Write("минимальное значение: ");
int minValue = int.Parse(Console.ReadLine());
Console.Write("максимальное значение: ");
int maxValue = int.Parse(Console.ReadLine());

void CreateRandomArray(int[] nameArray)
{
    for (int i = 0; i < 8; i++)
    {
        nameArray[i] = new Random().Next(minValue, maxValue);
    }
}

void PrintArray(int[] array)
{
    Console.Write("Созданный массив: ");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
}

int[] testArray = new int[8];
CreateRandomArray(testArray);
PrintArray(testArray);
