// See https://aka.ms/new-console-template for more information
// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine("Введите число от 1 до 7: ");
int n = Convert.ToInt32(Console.ReadLine());

string Week(int x)
{
    if (x == 6 || x == 7) return "День выходной, ура!";
    else return "Надо на работу(";
}
string result = Week(n);
Console.WriteLine(result);