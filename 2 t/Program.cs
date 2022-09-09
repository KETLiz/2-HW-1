// See https://aka.ms/new-console-template for more information

// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.WriteLine("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());

string Third(int x)
{
    if (x < 100) return "Третьей цифры нет";
    else
    {
        while (x > 1000)
        {
            x = x/10;
        }
        return $"Третья цифра числа равна {x%10}";
    }
}

string result = Third(n);
Console.WriteLine(result);