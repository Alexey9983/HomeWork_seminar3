// Задача №1. Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

Console.WriteLine("Введи число 1: ");
int num1 = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введи число 2: ");
int num2 = int.Parse(Console.ReadLine()!);

if (num1 == num2)
{
    Console.WriteLine($"числа {num1} и {num2} равны");
}
   
else
    if (num1 > num2)
    {
        Console.WriteLine($"число {num1} больше числа {num2}");
    }
    else
    {
        Console.WriteLine($"число {num2} больше числа {num1}");
    }


