/// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. 
// Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"


// System.Console.WriteLine("Введите число.");
// int N = Convert.ToInt32(Console.ReadLine());

// int LostNum = 1;

// string PrintNumber(int start, int end)
// {
//     if (start == end)
//     {
//         return start.ToString();
//     }
//     return start + " " + PrintNumber(start - 1, end);
// }

// System.Console.WriteLine(PrintNumber(N, LostNum));

/// Задача 66: Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в 
// промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

// System.Console.WriteLine("Введите число M");
// int M = Convert.ToInt32(Console.ReadLine());

// System.Console.WriteLine("Введите число N");
// int N = Convert.ToInt32(Console.ReadLine());

// int SumNumber = 0;

// int Sum(int numM, int numN)
// {
//     if (numM == numN)
//     {
//         return numM;
//     }
//     return (numM + Sum(SumNumber + (numM + 1), numN));
// }
// if (M > N)
// {
//     Console.WriteLine(Sum(N, M));
// }
// else if (M < N)
// {
//     Console.WriteLine(Sum(M, N));
// }
// else
// {
//     Console.WriteLine("Ввели равные числа");
// }

/// Задача 68: Напишите программу вычисления 
// функции Аккермана с помощью рекурсии. Даны 
// два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

// System.Console.WriteLine("Расчет функции Аккермана.");

// System.Console.Write("Введите число M: ");
// int M = Convert.ToInt32(Console.ReadLine());

// System.Console.Write("Введите число N: ");
// int N = Convert.ToInt32(Console.ReadLine());

// int Akkerman(int m, int n)
// {
//     if (m == 0)
//     {
//         return n + 1;
//     }
//     if (m > 0 && n == 0)
//     {
//         return Akkerman(m - 1, 1);
//     }
//     return Akkerman(m - 1, Akkerman(m, n - 1));
// }

// Console.WriteLine(Akkerman(M, N));

