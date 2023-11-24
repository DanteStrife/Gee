// Задача 10: 
// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

// int num = new Random(). Next(100,1000);

// Console.WriteLine(num);

// int result = (num /10) % 10;
// Console.WriteLine(result);


// Console.WriteLine("Введите трехзначное число");
// int num = Convert.ToInt32(Console.ReadLine());

// int result = (num /10) % 10;
// Console.WriteLine(result);


// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

// Console.WriteLine("Введите число.");
// int num = Convert.ToInt32(Console.ReadLine()); // Через цикл

// if (num < 100)
//     {
//     Console.WriteLine("Третья цифра отсутствует");
//     }
//         else 
//         if (num > 99 && num <1000) 
//         {
//         int result = num % 10;
//         Console.WriteLine(result);
//         }
//             else 
//             if (num > 999 && num <10000) 
//             {
//             int result = (num / 10) % 10;
//             Console.WriteLine(result);
//             }
//                 else 
//                 if (num > 9999 && num <100000) 
//                 {
//                 int result = (num / 100) % 10;
//                 Console.WriteLine(result);
//                 }



// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

// Console.WriteLine("Введите число от 1 до 7");
// int num = Convert.ToInt32(Console.ReadLine());

// if (num == 6 || num == 7)
//     {
//         Console.WriteLine("Спим:)");
//     }
//     else if (num > 0 && num <6)
//         {
//             Console.WriteLine("Отдыхать рано. Работай!");
//         }
// if (num > 7 || num == 0)
// Console.WriteLine("Это не день недели.");


// Console.WriteLine("Введите число.");
// int num = Convert.ToInt32(Console.ReadLine());

// if (num >= 100)
// {
//         while(num >= 1000)
//         {
//             num = num/10;
//         }
//         num = num%10;
//         Console.WriteLine(num);
// }
// else
// {
//     Console.WriteLine("Третьей цифры нет");
// }



Console.WriteLine("Введите число.");
int num = Convert.ToInt32(Console.ReadLine()); // Через цикл

if (num < 100)
    {
    Console.WriteLine("Третья цифра отсутствует");
    }
        else 
        if (num > 99 && num <1000) 
        {
        int result = num % 10;
        Console.WriteLine(result);
        }
            else 
            while(num > 999)
            {
                num = (num / 10);
            }