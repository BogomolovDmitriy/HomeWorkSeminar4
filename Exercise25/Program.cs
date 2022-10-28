//Задача 25: 
// Напишите (функцию) цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

double DegreeNumber(int num1,int num2)
{
    double result = Math.Pow(num1, num2);
    Console.WriteLine($"Рузультат: {result}");
    return result;
}

Console.Write("Введите число, которое нужно возвести в степень: ");
int a = int.Parse(Console.ReadLine());
Console.Write("Введите степень, для указанного числа: ");
int b = int.Parse(Console.ReadLine());

DegreeNumber(a, b);
