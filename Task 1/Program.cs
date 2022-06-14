// Задача 1: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

Console.Write("Введите первое число: ");
string first_str = Console.ReadLine();
Console.Write("Введите второе число: ");
string second_str = Console.ReadLine();

double first = double.Parse(first_str);
double second = double.Parse(second_str);

if (first>second)
    {
        Console.WriteLine($"Первое число больше второго" );
    }
    else if (first<second)
    {
        Console.WriteLine($"Второе число больше первого" );
    }
    else 
    { 
        Console.WriteLine("Числа рывны");
    }
