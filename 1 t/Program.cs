// See https://aka.ms/new-console-template for more information
// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.WriteLine("Введите трехзначное число: ");
int n = Convert.ToInt32(Console.ReadLine());

string Second(int x)
{
    int a = x/10;
    int b = a%10;
    return $"Вторая цифра числа равна: {b}";
}
string result = Second(n);
Console.WriteLine(result);