// Задача 2: Напишите программу, которая принимает на
// вход три числа и выдаёт максимальное из этих чисел.

Console.Write("Введите первое число: ");
string first_str = Console.ReadLine();
Console.Write("Введите второе число: ");
string second_str = Console.ReadLine();
Console.Write("Введите третье число: ");
string third_str = Console.ReadLine();


double first = double.Parse(first_str);
double second = double.Parse(second_str);
double third = double.Parse(third_str);

double max = first;

if (second > max) { max = second; }
if (third > max) { max = third; }

Console.WriteLine($"Мамаксимальное число: {max}");
