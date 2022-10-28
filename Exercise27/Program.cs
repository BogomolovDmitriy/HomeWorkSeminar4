// Задача 27: 
// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

int SumDigits(int num)
{
    int NumLength(int num)
    {
        int count = 0;
        while (num > 0)
        {
            num /= 10;
            count++;
        }
        return count;
    }

    int number = num;

    int numLength = NumLength(num);
    int[] digits = new int[numLength];
    for (int i = numLength - 1; i >= 0; i--)
    {
        digits[i] = number % 10;
        number /=10;
    }

    int result = 0;
    for (int i = 0; i < digits.Length; i++)
    {
        result += digits[i];
    }
    Console.WriteLine($"Сумма цифр числа {num} ровна: {result}.");
    return result;
}

Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine());
SumDigits(number);
