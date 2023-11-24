/// Задача 46: Задайте двумерный массив размером
//  m×n, заполненный случайными целыми числами.
// m = 3, n = 4.           5 5 3 5 6 8 9 3 2 
// 1 4 8 19
// 5 -2 33 -2
// 77 3 8 1

// System.Console.WriteLine("Введите число rows");
// int rows = Convert.ToInt32(Console.ReadLine());

// System.Console.WriteLine("Введите число columns");
// int columns = Convert.ToInt32(Console.ReadLine());

// int[,] array = new int[rows,columns];

// for (int i = 0; i < array.GetLength(0); i++)
// {
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//         array[i,j] = new Random().Next(1,10); // 1..9
//         System.Console.Write(array[i,j] + "  ");
//     }
//     System.Console.WriteLine();
// }


// void R (int[,]matrix)  //Функция для лзаполнения массива вручную
// {

// }


/// Задача 48: Задайте двумерный массив размера m на n, 
// каждый элемент в массиве находится по формуле: 
// Aₘₙ = m+n. Выведите полученный массив на экран.
// m = 3, n = 4.
// 0 1 2 3
// 1 2 3 4
// 2 3 4 5


// System.Console.WriteLine("Введите число rows");
// int rows = Convert.ToInt32(Console.ReadLine());

// System.Console.WriteLine("Введите число columns");
// int columns = Convert.ToInt32(Console.ReadLine());

// int[,] array = new int[rows,columns];

// for (int i = 0; i < array.GetLength(0); i++)
// {
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//         array[i,j] = i+j; // 1..9
//         System.Console.Write(array[i,j] + "  ");
//     }
//     System.Console.WriteLine();
// }


/// Задача 49: Задайте двумерный массив. Найдите 
// элементы, у которых оба индекса чётные,
//  и замените эти элементы на их квадраты.
// Например, изначально массив
//  выглядел вот так:
// 1 4 7 2   1 4 49 2
// 5 9 2 3   5 9 2 3
// 8 4 2 4   64 4 4 4 

//Вариант без вызова функции

// Console.WriteLine("Введите число");
// int rows = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите число");
// int columns = Convert.ToInt32(Console.ReadLine());

// int[,] array = new int[rows,columns];

// for (int i = 0; i < array.GetLength(0); i++)
// {
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//         array[i,j] = new Random().Next(1,10);;

//         System.Console.Write(array[i,j] + "\t");
//     }
//     System.Console.WriteLine();
// }

// System.Console.WriteLine();

// for (int i = 0; i < array.GetLength(0); i++)
// {
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//         if(i%2 ==0 && j%2==0)
//         {
//             array[i,j] = array[i,j] * array[i,j];
//         }        

//         System.Console.Write(array[i,j] + "\t");
//     }
//     System.Console.WriteLine();
// }

///Вариант с вызовом и созданием функции

// Console.WriteLine("Введите число");
// int rows = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите число");
// int columns = Convert.ToInt32(Console.ReadLine());

// int[,] CreatArray()
// {
//     int[,] array = new int[rows,columns];

//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i,j] = new Random().Next(1,10);
//         }
//     }
//     return array;
// }

// void PrintArray(int[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             System.Console.Write(matrix[i,j] + "\t  ");
//         }
//         System.Console.WriteLine();
//     }
// }

// int[,] ChangeArray(int[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             if(i%2 ==0 && j%2==0)
//             {
//                 matrix[i,j] = matrix[i,j] * matrix[i,j];
//             }        
//         }
//     }
//     return matrix;
// }

// int[,] arrayResult= CreatArray(); // создаем пустой массив и кладем в него другой
// PrintArray(arrayResult); // вызов массива

// System.Console.WriteLine();

// ChangeArray(arrayResult); // изменение массива
// PrintArray(arrayResult); // вызов измененного массива


/// Задача 51: Задайте двумерный массив. Найдите сумму 
// элементов, находящихся на главной диагонали
//  (с индексами (0,0); (1;1) и т.д.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Сумма элементов главной диагонали: 1+9+2 = 12

// Console.WriteLine("Введите число");
// int rows = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите число");
// int columns = Convert.ToInt32(Console.ReadLine());

//  int sum=0;

// int[,] CreatArray()
// {
//     int[,] array = new int[rows,columns];

//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i,j] = new Random().Next(1,10);

            
//         }
//     }
    
//     return array;
// }
// void PrintArray(int[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             System.Console.Write(matrix[i,j] + "\t  ");
//              if(i==j)
//             {
//                sum= sum + matrix[i,j];
//             } 
//         }
//         System.Console.WriteLine();
//     }
//     System.Console.WriteLine(sum);
// }

// void GetSum(int[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             if(i==j)
//             {
//                sum= sum + matrix[i,j];
//             }        
//         }
//     }
//     System.Console.WriteLine(sum);
// }

// int[,] arrayResult= CreatArray();
// PrintArray(CreatArray());

// System.Console.WriteLine();

// // GetSum(arrayResult);

