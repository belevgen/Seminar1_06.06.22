// Задача 3: Напишите программу, которая на вход
// принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

Console.Write("Введите число: ");
string number_str = Console.ReadLine();
int number = int.Parse(number_str);
if (number % 2 == 0)
{
    Console.WriteLine($"{number_str} число четное");
}
else
{
    Console.WriteLine($"{number_str} число не четное");
}
