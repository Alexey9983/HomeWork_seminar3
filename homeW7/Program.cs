/*Задача 47. Задайте двумерный массив размером m × n, заполненный случайными вещественными числами.
m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9*/
//-------------Методы к задаче 1 (47)----------------------------
// double[,] GetArray(int m, int n, int minValue, int maxValue)
// {
//     double[,] result = new double[m,n];
//     for(int i = 0; i < m; i++)
//     {
//         for(int j = 0; j < n; j++)
//         {
//             result[i,j] = new Random().Next(minValue, maxValue) * new Random().NextDouble();
//         }
//     }
//     return result;
// }

// void PrintArray(double[,] array)
// {
//     Console.WriteLine("v--РЕЗУЛЬТАТ--v");
//     for(int i = 0; i < array.GetLength(0); i++)
//     {
//         for(int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write("{0,7:F1}", array[i,j]);
//         }
//         Console.WriteLine();
//     }
// }
//-----------------------------------------------------------------

// Console.WriteLine("Введите количество строк: ");
// int rows = int.Parse(Console.ReadLine()!);
// Console.WriteLine("Введите количество столбцов: ");
// int columns = int.Parse(Console.ReadLine()!);
// double[,] array = GetArray(rows, columns, -100, 100);
// PrintArray(array);


//____________________________________________________________________________________________________________________________________________
/*Задача 50. Напишите программу, которая на вход принимает число, проверяя есть ли такое число в двумерном массиве и возвращает сообщение о том, 
что оно найдено или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет*/

//-------------Методы к задаче 2(50) и 3 (52)----------------------------

int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return result;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}
//-----------------------------------------------------------------

// Console.WriteLine("Введите искомое число: ");
// int num = int.Parse(Console.ReadLine()!);
// int[,] array = GetArray(3, 3, 1, 10);
// PrintArray(array);
// bool N = false;
// for (int i = 0; i < array.GetLength(0); i++)
// {
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//         if (array[i, j] == num)
//         {
//             N = true;
//         }
//     }
// }
// if (N)
//     Console.WriteLine($"Число в массиве найдено!!!");
// else
//     Console.WriteLine("Число не найдено");

//____________________________________________________________________________________________________________________________________________
/*Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.*/
 
int[,] array = GetArray(2, 10, 1, 10);
PrintArray(array);
Console.WriteLine("среднее арифметическое элементов в каждом столбце:");
for (int j = 0; j < array.GetLength(1); j++)
{
    double sum = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        sum += array[i, j];
    }
    Console.Write($"{ sum / array.GetLength(0)}| ");
}
