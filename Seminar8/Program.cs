/// Задача 53: Задайте двумерный массив. Напишите 
// программу, которая поменяет местами первую и последнюю строку массива.

// Console.WriteLine("Введите число");
// int rows = Convert.ToInt32(Console.ReadLine()); //5

// Console.WriteLine("Введите число");
// int columns = Convert.ToInt32(Console.ReadLine());//2

// int[,] CreateArray()
// {
//     int[,] array = new int[rows,columns]; 

//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i,j] = new Random().Next(0,10);
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
//             System.Console.Write(matrix[i,j]+ "\t");
//         }
//         System.Console.WriteLine();
//     }
// }

// int[,] ChangeArray(int[,] matrix)
// {
//     int indexEndRow = matrix.GetLength(0)-1;

//     for (int j = 0; j < matrix.GetLength(1); j++)
//     {
//         int temp = matrix[0,j];
//         matrix[0,j] = matrix[indexEndRow,j];
//         matrix[indexEndRow,j] = temp;
//     }
//     return matrix;
// }

// int[,] result = CreateArray();
// PrintArray(result); // Выводит начаольный массив
// ChangeArray(result); // Изменяет массив
// System.Console.WriteLine();
// PrintArray(result); // Выводит измененный массив


/// Задача 59: Задайте двумерный массив из целых чисел. 
// Напишите программу, которая удалит строку и столбец,
//  на пересечении которых расположен наименьший элемент массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Наименьший элемент - 1, на выходе получим 
// следующий массив:
// 923
// 424
// 267


// Console.WriteLine("Введите число");
// int rows = Convert.ToInt32(Console.ReadLine()); //5

// Console.WriteLine("Введите число");
// int columns = Convert.ToInt32(Console.ReadLine());//2

// int minElement= 10;
// int rowMinEl=0;
// int columnsMinEl=0;

// int[,] CreateArray()
// {
//     int[,] array = new int[rows,columns]; 

//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i,j] = new Random().Next(0,10);

//             if(minElement > array[i,j])
//             {
//                 minElement = array[i,j];
//                 rowMinEl= i;
//                 columnsMinEl = j;
//             }
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
            
//             System.Console.Write(matrix[i,j]+ "\t");
//         }
//         System.Console.WriteLine();
//     }
// }

// void ChangeArray(int[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             if(i != rowMinEl && j != columnsMinEl)
//             {
//                 System.Console.Write(matrix[i,j]+ "\t");
//             }
//         }
//         System.Console.WriteLine();
//     }
// }

// int[,] result = CreateArray();
// PrintArray(result);

// System.Console.WriteLine();
// ChangeArray(result);


/// Задача 55: Задайте двумерный массив.
//  Напишите программу, которая заменяет 
//  строки на столбцы. В случае, если это 
//  невозможно, программа должна вывести сообщение для пользователя.

Console.WriteLine("Введите число");
int rows = Convert.ToInt32(Console.ReadLine()); //5


int[,] CreateArray()
{
    int[,] array = new int[rows,rows]; 

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i,j] = new Random().Next(0,10);
        }
    }
    return array;
}

void PrintArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            
            System.Console.Write(matrix[i,j]+ "\t");
        }
        System.Console.WriteLine();
    }
}

int[,] ChangeArray(int[,] matrix)
{
    int[,] result = new int[rows,rows];

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
           result[j,i] = matrix[i,j];
        }
    }
    return result;
}

int[,] result = CreateArray();
PrintArray(result);

System.Console.WriteLine();
PrintArray(ChangeArray(result));