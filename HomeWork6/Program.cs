/// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3


// System.Console.WriteLine("Какое количество чисел?");
// int M = Convert.ToInt32(Console.ReadLine());
// int count = 0; // Счетчик введенных чисел
// int countPolNum = 0; // Колличество положительных чисел

// for ( count = 0; count < M; count++)
// {
//     System.Console.Write("Введите число ");
//     int num = Convert.ToInt32(Console.ReadLine());
//     if (num > 0)
//         countPolNum++;
// }

// System.Console.WriteLine($"Колличество положительных чисел: " + countPolNum);


/// Задача 41*: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь. 
//(Неизвестно сколько чисел введет пользоватьль)
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

// int count = 0; // Счетчик введенных чисел
// int countPolNum = 0; // Колличество положительных чисел


// System.Console.Write("Введите число ");
// int num = Convert.ToInt32(Console.ReadLine());
// count++;
// if (num > 0)
//     countPolNum++;

// System.Console.WriteLine($"Колличество введенных чисел чисел: " + count);
// System.Console.WriteLine($"Колличество положительных чисел: " + countPolNum);
// Console.Write("Press <Enter> to exit... ");
// while (Console.ReadKey().Key != ConsoleKey.Enter) { }


/// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 
// задаются пользователем. b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)


System.Console.Write("Введите значение b1: ");
double b1 = Convert.ToInt32(Console.ReadLine());

System.Console.Write("Введите значение k1: ");
double k1 = Convert.ToInt32(Console.ReadLine());

System.Console.Write("Введите значение b2: ");
double b2 = Convert.ToInt32(Console.ReadLine());

System.Console.Write("Введите значение k2: ");
double k2 = Convert.ToInt32(Console.ReadLine());


if (k1 == k2)
{
    System.Console.WriteLine("Прямые параллельны.");

    if (b1 != b2)
    {
        System.Console.WriteLine("Прямые различны и не имеют пересечений, в противном же случае прямые совпадают.");
    }
}
else
{
    double x = (b2 - b1) / (k1 - k2);

    double y = k1 * x + b1;

System.Console.WriteLine($"Точка пересечения с координатами: x = {x} , y = {y}");
}

