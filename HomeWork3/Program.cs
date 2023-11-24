/// Внутри класса Answer напишите метод IsPalindrome, который принимает на вход
//  пятизначное число number и проверяет, является ли оно палиндромом.

// Метод должен проверить является ли число пятизначным, 
// в противном случае - вывести Число не пятизначное и False в следующей строке.

// Для остальных чисел вернуть True или False.


// Console.WriteLine("Введите пятизначное число");
// int numX = Convert.ToInt32(Console.ReadLine());
// int num1 = (numX / 10000);
// int num5 = (numX % 10);
// int num2 = ((numX / 1000) % 10);
// int num4 = ((numX / 10) % 10);

// if (numX < 10000 || numX > 99999)
// {
//     Console.WriteLine("Число не пятизначное");
// }

// if (num2 == num4 && num1 == num5 && numX > 9999 && numX <100000)
//     {
//     Console.WriteLine("True");
//     }
// else
// Console.WriteLine("False");



// Для автотеста

   
// if (number < 10000 || number > 99999)
//   {
//       Console.WriteLine("Число не пятизначное");
//       return false;
//   }
// else
//     {   
//       if ((number / 1000) % 10 == (number / 10) % 10 && number / 10000 == number % 10 )
//       {
//       return true;
//       }
//       else
//           {
//      return false;
//           }
//     }


/// 3D пространство

// Внутри класса Answer напишите метод DistanceBetweenPoints,
//  который принимает на вход координаты двух точек pointA и 
//  pointB в виде массива целых чисел, и возвращает расстояние 
//  между ними в 3D пространстве.


// A (3,6,8); B (2,1,-7) -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

// Console.WriteLine("Введите число");
// int x1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите число");
// int y1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите число");
// int z1 = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите число");
// int x2 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите число");
// int y2 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите число");
// int z2 = Convert.ToInt32(Console.ReadLine());


// double distsnceLeangth = Math.Sqrt(Math.Pow(x2 - x1,2) + Math.Pow(y2 - y1,2) + Math.Pow(z2 - z1,2));
// System.Console.WriteLine(distsnceLeangth);

//Для автотеста

// double distsnceLeangth = Math.Sqrt(Math.Pow(pointA[0] - pointB[0],2) + Math.Pow(pointA[1] - pointB[1],2) + Math.Pow(pointA[2] - pointB[2],2));
      
// return distsnceLeangth;



///Таблица кубов

// Внутри класса Answer напишите метод ShowCube,
//  который принимает на вход число (N) и 
//  выводит таблицу кубов чисел от 1 до N (включительно)
//   каждое на новой строке.


System.Console.WriteLine("Введите число");
int N = Convert.ToInt32(Console.ReadLine());

// for (int i = 1; i <= N ; i++)
//     {
//     System.Console.WriteLine(Math.Pow (i , 3));
//     }


///Неизвестная задача
// Console.WriteLine("Введите трёхзначное число:");
// int num = Convert.ToInt32(Console.ReadLine());


// if (num < 100 && num > 1000)
// {
//     int result = num / 10 % 10;
//     Console.WriteLine("Вы ввели не трёхзначное число");
// }

// else
// {
//     if (num <0)
//     {
//         int result = num / 10 % 10* (-1);
//         Console.WriteLine($"число отрицательное, нужная цифра {result}");
//     }
//     else
//     {
//         int result = num / 10 % 10 ;
//         Console.WriteLine($"число положительное, нужная цифра {result}");
//     }
    
// }


