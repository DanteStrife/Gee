/// Напишите программу для работы с матрицей целых чисел.

// Реализуйте класс MatrixOperations, который содержит 
// ледующие статические методы:

// PrintMatrix(int[,] matrix): Метод для вывода матрицы 
// на экран. Он принимает на вход двумерный массив целых 
// чисел matrix и выводит его элементы в виде таблицы.

// SortRowsDescending(int[,] matrix): Метод для сортировки 
// строк матрицы по убыванию. Он принимает на вход двумерный 
// массив целых чисел matrix и сортирует каждую строку 
// матрицы так, чтобы элементы в каждой строке шли по убыванию.


// Console.WriteLine("Создаем двумерный массив.");


// Console.Write("Введите число строк. ");
// int m = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите столбцов. ");
// int n = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите минимальное значение в массиве. ");
// int minLimitRandom = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите максимальное значенние в массиве. ");
// int maxLimitRandom = Convert.ToInt32(Console.ReadLine());


// int[,] CreateRandomMatrix() // Создание массива со случайными числами
// {
//     int[,] matrix = new int[m, n];
//     Random rand = new Random();
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             matrix[i, j] = rand.Next(minLimitRandom, maxLimitRandom);
//         }
//     }

//     return matrix;
// }


// void PrintArray(int[,] matrix) //Вывод массива
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             System.Console.Write(matrix[i, j] + "\t");
//         }
//         System.Console.WriteLine();
//     }
// }


// int[,] SortRowsDescending(int[,] Sortmatrix) // Отсортированный массив (Метод пузырька)
// {
//     for (int i = 0; i < Sortmatrix.GetLength(0); i++)  //проверяем все строки
//     {
//         for (int j = 0; j < Sortmatrix.GetLength(1); j++)  //Начиная с каждого элемента столбца
//         {
//             int max = Sortmatrix[i, j];
//             int m = j;
//             for (int k = j; k < Sortmatrix.GetLength(1); k++)   // проверка, больше ли какое-либо число, чем в j-позиции
//             {
//                 if (Sortmatrix[i, k] > max)  // если найден новый максимум, запомним его позицию
//                 {
//                     max = Sortmatrix[i, k];
//                     m = k;
//                 }
//             }
//             int tmp = Sortmatrix[i, j];  // Меняем местами максимальную и текущую j-позицию
//             Sortmatrix[i, j] = max;
//             Sortmatrix[i, m] = tmp;
//         }
//     }
//     return Sortmatrix;
// }

// System.Console.WriteLine();

// System.Console.WriteLine("Исходный массив:");

// int[,] result = CreateRandomMatrix();
// PrintArray(result);
// System.Console.WriteLine();


// System.Console.WriteLine("Отсортированный по убыванию массив:");
// PrintArray(SortRowsDescending(result));


///Напишите программу для работы с матрицей целых чисел.

// Реализуйте класс Answer, который содержит следующие статические методы:

// SumOfRow(int[,] matrix, int row): Метод для вычисления суммы элементов 
// в заданной строке row матрицы matrix. Метод принимает двумерный массив 
// целых чисел matrix и номер строки row, а возвращает целое число - сумму 
// элементов в данной строке.

// MinimumSumRow(int[,] matrix): Метод для определения строки с наименьшей 
// суммой элементов. Метод принимает двумерный массив целых чисел matrix и 
// возвращает массив из двух элементов: номер строки с наименьшей суммой 
// (нумерация начинается с 0) и саму сумму.

// Console.WriteLine("Создаем двумерный массив.");


// Console.Write("Введите число строк. ");
// int m = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите столбцов. ");
// int n = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите минимальное значение в массиве. ");
// int minLimitRandom = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите максимальное значенние в массиве. ");
// int maxLimitRandom = Convert.ToInt32(Console.ReadLine());


// int[,] CreateRandomMatrix() // Создание массива со случайными числами
// {
//     int[,] matrix = new int[m, n];
//     Random rand = new Random();
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             matrix[i, j] = rand.Next(minLimitRandom, maxLimitRandom);
//         }
//     }

//     return matrix;
// }


// void PrintArray(int[,] matrix) //Вывод массива
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             System.Console.Write(matrix[i, j] + "\t");
//         }
//         System.Console.WriteLine();
//     }
// }

// int SumOfRow(int[,] matrix, int row)
// {
//     int sumRow = 0;
//     for (int column = 0; column < matrix.GetLength(1); column++)
//     {
//         sumRow += matrix[row, column];
//     }
//     return sumRow;
// }

// int[] MinimumSumRow(int[,] matrix)
// {
//     int[] MinimumSumRowSearch = new int[2] { 0, 0 };
//     for (int s = 0; s < matrix.GetLength(0); s++)
//     {
//         MinimumSumRowSearch[1] += matrix[0, s];
//     }
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         int Minimum = 0;
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             Minimum += matrix[i, j];
//         }
//         if (Minimum < MinimumSumRowSearch[1])
//         {
//             MinimumSumRowSearch[1] = Minimum;
//             MinimumSumRowSearch[0] = i;
//         }
//     }
//     return MinimumSumRowSearch;
// }




// System.Console.WriteLine();
// int[,] result = CreateRandomMatrix();
// PrintArray(result);
// System.Console.WriteLine();


// int[] minSumRow = MinimumSumRow(result);
// Console.WriteLine($"\nСумма наименьшей строки (строка {minSumRow[0] + 1}): {minSumRow[1]}");
// System.Console.WriteLine();

// int rowToSum = 1;                                  /// Присутствует ошибка при выводе номера строки с минимальной суммой элементов
// int sum = SumOfRow(result, rowToSum);
// Console.WriteLine($"Сумма элементов в строке {rowToSum + 1}: {sum}");


/// Реализуйте класс MatrixOperations, который содержит 
// следующие статические методы:

// MultiplyIfPossible(int[,] matrixA, int[,] matrixB): 
// Метод для проверки, возможно ли умножения двух матриц 
// matrixA и matrixB. Если число столбцов в матрице 
// matrixA не равно числу строк в матрице matrixB, 
// то выводится сообщение "It is impossible to multiply." 
// В противном случае, вызывается метод MatrixMultiplication 
// для умножения матриц, и результат выводится с помощью 
// метода PrintMatrix.

// MatrixMultiplication(int[,] matrixA, int[,] matrixB): 
// Метод для умножения двух матриц matrixA и matrixB. 
// Метод возвращает новую матрицу, которая представляет 
// собой результат умножения матрицы matrixA на матрицу matrixB.

// PrintMatrix(int[,] matrix): Метод для вывода матрицы на консоль.

// Если аргументы не переданы, программа использует матрицы
// по умолчанию. Если аргументы переданы, программа парсит 
// их в двумерные массивы целых чисел и выполняет умножение матриц.

// Console.WriteLine("Создаем двумерный массив.");


// Console.Write("Введите число строк matrixA. ");
// int m = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите столбцов matrixA. ");
// int n = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите число строк matrixB. ");
// int x = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите столбцов matrixB. ");
// int y = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите минимальное значение в массиве. ");
// int minLimitRandom = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите максимальное значенние в массиве. ");
// int maxLimitRandom = Convert.ToInt32(Console.ReadLine());


// void PrintMatrix(int[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             System.Console.Write(matrix[i, j] + "\t");
//         }
//         System.Console.WriteLine();
//     }
// }

// int[,] CreateMatrixA()
// {
//     int[,] matrix = new int[m, n];
//     Random rand = new Random();
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             matrix[i, j] = rand.Next(minLimitRandom, maxLimitRandom);
//         }
//     }

//     return matrix;
// }

// int[,] CreateMatrixB()
// {
//     int[,] matrix = new int[x, y];
//     Random rand = new Random();
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             matrix[i, j] = rand.Next(minLimitRandom, maxLimitRandom);
//         }
//     }

//     return matrix;
// }

// void MultiplyIfPossible(int[,] matrixA, int[,] matrixB)
// {
//     if (matrixA.GetLength(1) != matrixB.GetLength(0))
//     {
//         System.Console.WriteLine("It is impossible to multiply.");
//     }
//     else
//     {
//         MatrixMultiplication(matrixA,matrixB);
//     }
// }

// int[,] MatrixMultiplication(int[,] matrixA, int[,] matrixB)
// {
//     int[,] matrixC = new int[matrixA.GetLength(0), matrixB.GetLength(1)];
//     for (int i = 0; i < matrixA.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrixB.GetLength(1); j++)
//         {
//             for (int f = 0; f < matrixA.GetLength(1); f++)
//             {
//                 matrixC[i,j] += matrixA[i, f] * matrixB[f, j];
//             }
//         }
//     }
//      PrintMatrix(matrixC);
//     return matrixC;
// }

// System.Console.WriteLine();
// int[,] A = CreateMatrixA();
// PrintMatrix(A);

// System.Console.WriteLine();
// int[,] B = CreateMatrixB();
// PrintMatrix(B);

// System.Console.WriteLine();
// PrintMatrix(MatrixMultiplication());  /// ошибка с аргументом

using System;

public class Answer
{
    public static void MultiplyIfPossible(int[,] matrixA, int[,] matrixB)
    { // Введите свое решение ниже
    if (matrixA.GetLength(1) != matrixB.GetLength(0))   {Console.WriteLine("It is impossible to multiply.");}
    else {MatrixMultiplication(matrixA, matrixB);}

    }

    public static int[,] MatrixMultiplication(int[,] matrixA, int[,] matrixB)
    {  // Введите свое решение ниже
    int [,] matrixC = new int [matrixA.GetLength(0),matrixB.GetLength(1)];
    for (int i = 0; i < matrixA.GetLength(0); i++)
        {
            for (int j = 0; j < matrixB.GetLength(1); j++)
            {
              for (int f = 0; f < matrixA.GetLength(1); f++)
                {
                matrixC[i,j] += matrixA[i,f] * matrixB[f,j];
                }
            }
        }
    PrintMatrix(matrixC);
    return matrixC;
    }

    public static void PrintMatrix(int[,] matrix)
    {  // Введите свое решение ниже
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++) {Console.Write($"{matrix[i, j]}\t");}
            Console.WriteLine();
        }
    }
 // Не удаляйте и не меняйте метод Main!
    public static void Main(string[] args)
    {
        int[,] matrix;

        if (args.Length == 0)
        {
            // Если аргументы не переданы, используем матрицу по умолчанию
            matrix = new int[,]
            {
                {5, 2},
                {8, 1}
            };
        }
        else
        {
            // Иначе, парсим аргументы в двумерный массив
            string[] rows = args[0].Split(';');
            matrix = new int[rows.Length, rows[0].Split(',').Length];
            for (int i = 0; i < rows.Length; i++)
            {
                string[] elements = rows[i].Split(',');
                for (int j = 0; j < elements.Length; j++)
                {
                    if (int.TryParse(elements[j], out int number))
                    {
                        matrix[i, j] = number;
                    }
                    else
                    {
                        Console.WriteLine($"Ошибка при парсинге аргумента {elements[j]}.");
                        return;
                    }
                }
            }
        }

        Console.WriteLine("Исходная матрица:");
        PrintMatrix(matrix);

        int[,] matrixB = {
            {5, 6},
            {7, 8}

        };

        Console.WriteLine("\nMatrix B:");
        PrintMatrix(matrixB);

        Console.WriteLine("\nMultiplication result:");

        MultiplyIfPossible(matrix, matrixB);
    }
}