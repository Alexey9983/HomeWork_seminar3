//____________________________________________________________________________________________________________________________
// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

// Console.Write("Введите число N: ");
// int N = int.Parse(Console.ReadLine()!);
// Console.WriteLine(PrintNumbers(N, 1));

// ------Метод---------
// string PrintNumbers(int start, int end)
// {
//     if (start == end) return start.ToString();
//         return (start + " " + PrintNumbers(start - 1, end));
// }

//____________________________________________________________________________________________________________________________
/*Задача 66: Выполнить с помощью рекурсии.Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30*/

// Console.Write("Введите начальное число M: ");
// int M = int.Parse(Console.ReadLine()!);
// Console.Write("Введите конечное число N: ");
// int N = int.Parse(Console.ReadLine()!);

// Console.WriteLine($"Сумма элементов в промежутке от {M} до {N} будет = {PrintSumNumbers(M,N)}");
// -----------метод----------
// int PrintSumNumbers(int M, int N)
// {
//     if(M > N) return 0;
//     return(M + PrintSumNumbers(M+1,N));
// }

//____________________________________________________________________________________________________________________________
/*Задача 68: Выполнить с помощью рекурсии.Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29*/

Console.Write("Введите число m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число n: ");
int n = Convert.ToInt32(Console.ReadLine());

AkmanFun(m,n);
void AkmanFun(int m, int n)
{
    Console.Write($"Результат = {Akman(m, n)}"); 
}
int Akman(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if (n == 0 && m > 0)
    {
        return Akman(m - 1, 1);
    }
    else
    {
        return (Akman(m - 1, Akman(m, n - 1)));
    }
}