//-------метод--------
int[] GetArray (int size, int minValue, int maxValue)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(minValue, maxValue + 1);
    }
    return array;
}
/*-----------------------------------------------------------------------------------------------------------------------------------
Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел строго больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 4
Для строки можно использовать данный метод string[] numS = stringArray.Split(' ', StringSplitOptions.RemoveEmptyEntries)
(пользователь вводит в консоли числа через пробел и они формируют строку)*/

// Console.WriteLine("Введите размер массива");
// int M = int.Parse(Console.ReadLine()!);
// Console.WriteLine("Введите минимальный элемент массива");
// int min = int.Parse(Console.ReadLine()!);
// Console.WriteLine("Введите максимальный элемент массива");
// int max = int.Parse(Console.ReadLine()!);

// int count = 0;

// int[] array = GetArray(M, min, max);
    
// foreach (int el in array)
// {       
//     if (el > 0)
//     {
//         count++; 
//     }
// }

// Console.WriteLine($"В массиве [{String.Join(", ", array)}] количество положительных чисел -> {count}");

/*-----------------------------------------------------------------------------------------------------------------------------------
Задача 43: Написать программу, которая на вход принимает массив из любого количества элементов (не менее 6)в промежутке от 0 до 100, 
а на выходе выводит этот же массив, но отсортированный по возрастанию(от меньшего числа к большему).*/

int[] array = GetArray(6, 0, 100);
Console.WriteLine($"[{String.Join(",", array)}]");
    int temp;
    for (int i = 0; i < array.Length; i++)
    {
        for (int j = i + 1; j < array.Length; j++)
        {
            if (array[i] > array[j])
            {
                temp = array[i];
                array[i] = array[j];
                array[j] = temp;
            }
        }
    }
Console.WriteLine($"Результат задачи ->[{String.Join(",", array)}]");