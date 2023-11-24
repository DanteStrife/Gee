/// Задача 24: Напишите программу, которая принимает 
// на вход число (А) и выдаёт сумму чисел от 1 до А.
// 7 -> 28
// 4 -> 10
// 8 -> 36

// тип возвращающего значения + Название + () + {}

// Console.WriteLine("Введите число");
// int num = Convert.ToInt32(Console.ReadLine());

// int GetSum()
// {
//     int start = 1;
//     int sum=0;
     
//     while(start<= num)
//     {
//         sum += start;
//      // sum = sum +start;
//         start++;
//     }
//     return sum;
// }

// // int result= GetSum();
// // System.Console.WriteLine(result);

// System.Console.WriteLine(GetSum());


/// Задача 26: Напишите программу, которая принимает 
// на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

// System.Console.WriteLine("Введите число");
// int num = Convert.ToInt32(Console.ReadLine());

// int GetCountNumbers(int newNum)
// {
//     int count = 0;
     
//     while(newNum> 0)
//     {
//         newNum/=10;
//     // newNum = newNum/10;
//         count++;
//     }
//     return count;
// }

// // int result= GetSum();
// // System.Console.WriteLine(result);

// Console.WriteLine(GetCountNumbers(num));


/// Задача 28: Напишите программу, которая принимает
//  на вход число N и выдаёт произведение чисел от 1 до N.
// 4 -> 24 
// 5 -> 120

// System.Console.WriteLine("Введите число");
// int num = Convert.ToInt32(Console.ReadLine()); // пределы размера числа int32 ; чтобы исползовать числа еще больше то испльзовать переменные double или long, вместо int

// int Multiplication() // чтобы исползовать числа еще больше то испльзовать переменные double(целые числа с плавающей запятой) или long(целые числа), вместо int
// {
//     int start = 1;
//     int multiplication = 1;
     
//     while(start<= num)
//     {
//         multiplication *= start;
//      // Multiplication = Multiplication +start;
//         start++;
        
//     }
//     return multiplication;
// }

// // int result= GetSum();
// // System.Console.WriteLine(result);

// Console.WriteLine(Multiplication());


/// Задача 30: Напишите программу, которая выводит 
// массив из 8 элементов, заполненный нулями и 
// единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]

// CreateArray();

// void CreateArray()
// {
//     int[] array = new int[8];

//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] = new Random().Next(0,2);
//         System.Console.Write(array[i]+ " "); 
//     }
// }

