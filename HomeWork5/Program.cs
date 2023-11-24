/// Количество четных элементов в массиве

// Напишите программу, которая подсчитывает количество четных
//  элементов в массиве целых положительных трехзначных чисел
//   и выводит результат на экран.

// Программа должна иметь метод CountEvenElements,
//  который принимает массив целых положительных 
//  трехзначных чисел и возвращает количество четных элементов в массиве.

// Программа должна иметь метод PrintArray, который выводит
//  элементы массива на экран.

// При выводе элементы массива должны быть разделены символом табуляции "\t".

// Если аргументы командной строки не переданы, программа использует
//  массив по умолчанию, который содержит следующие значения:
//   {100, 102, 105, 166, 283, 764, 300, 499, 133}.

// CreateArray();

// void CreateArray()
// {
//     System.Console.WriteLine("Обозначьте длину массива");
//     int num = Convert.ToInt32(Console.ReadLine());
//     int count = 0;
//     int[] array = new int[num];

//     for (int i = 0; i < num; i++)
//     {
//         array[i] = new Random().Next(0, 1000);
//         Console.Write(array[i] + "\t ");

//         if (array[i] > 99 && array[i] < 1000)
//         {
//             array[i] = array[i] % 2;

//             if (array[i] == 0)
//             {
//                 count += 1;
//             }
//         }
//     }
//     System.Console.WriteLine("\nКоличество четных элементов: " + count);
// }


//Для патотеста

    //   int evenCount = 0;
    //   for (int i = 0; i < array.Length; i++)
    //     {
    //       if (array[i]%2 == 0) evenCount++;
    //     }
    //   return evenCount;

    // }

    // public static void PrintArray(int[] array)
    // {
    // // Введите свое решение ниже
    //   Console.Write($"{array[0]}");
    //   for (int i=1; i<array.Length; i++)
    //   {
    //     Console.Write($"\t{array[i]}");
    //   }
    //   Console.WriteLine();

    // }


/// Сумма нечетных элементов массива

// Напишите программу, которая находит сумму
//  элементов с нечетными индексами в одномерном
//   массиве целых чисел и выводит результат на экран.

//   Программа должна иметь метод SumOddElements, 
//   который принимает массив целых чисел и возвращает 
//   сумму элементов с нечетными индексами в массиве.

//   Программа должна иметь метод PrintArray, 
//   который выводит элементы массива на экран.

//   При выводе элементы массива должны быть 
//   разделены символом табуляции "\t".

// CreateArray();

// void CreateArray()
// {
//     System.Console.WriteLine("Обозначьте длину массива");
//     int num = Convert.ToInt32(Console.ReadLine());
//     int SumElements = 0;
//     int[] array = new int[num];

//     for (int i = 0; i < num; i++)
//     {
//         array[i] = new Random().Next(0, 100);
//         Console.Write(array[i] + "\t ");
//         int index = i % 2;

//             if (index != 0)
//             {
//                 SumElements += array[i];
//             }
//     }
//     System.Console.WriteLine("\nСумма нечетных элементов: " + SumElements);
// }  Не верно, так как отчет по индексу в сумме начинается с 0, а не с 1.


//Для Автотеста

//     int SumElements = 0;
//     for (int i = 1; i < array.Length; i+=2)
//     {

//                SumElements += array[i];
//     }
//     return SumElements;
//     }

//     public static void PrintArray(int[] array)
//     {
//          // Введите свое решение ниже

// for (int i = 0; i < array.Length; i++)
//       {
//         Console.Write(array[i]);
//         if (i < array.Length - 1) // Проверяем, не последний ли элемент
//         {
//         Console.Write("\t"); // Добавляем табуляцию после всех элементов, кроме последнего
//         }
//       }
//         Console.WriteLine();

//     }

/// Разница между максимальным и минимальным элементами массива

// Напишите программу для работы с массивом вещественных чисел.
// Реализуйте класс ArrayOperations, который содержит следующие статические методы:

// FindMax(double[] array): Метод принимает на вход
// массив вещественных чисел array и возвращает максимальное 
// число из массива.

// FindMin(double[] array): Метод принимает на вход массив 
// вещественных чисел array и возвращает минимальное число 
// из массива.

// CalcDifferenceBetweenMaxMin(double[] array): Метод 
// принимает на вход массив вещественных чисел array и 
// возвращает разницу между максимальным и минимальным 
// числами в массиве.

// PrintArray(double[] array): Метод для вывода 
// массива на экран. Он принимает на вход массив 
// array и выводит его элементы с двумя знаками 
// после запятой через табуляцию.


// CreateArray();

// void CreateArray()
// {
//     int i;
//     double FindMin = 100;
//     double FindMax = 0;
//     int[] array = new int[5];

//     for ( i = 0; i < array.Length; i++)
//     {
//         array[i] = new Random().Next(0, 100);
//         Console.Write(array[i] + "\t ");  

//         if (FindMax < array[i])
//         {
//         FindMax = array[i];
//         }
//     }
//     for ( i = 0; i < array.Length; i++)
//     {
//         if (FindMin > array[i])
//         {
//         FindMin = array[i];
//         }
//     }
//     double DifferentMinMax = FindMax - FindMin;
//     System.Console.WriteLine();
//     System.Console.WriteLine($"Минимальное значение=" + FindMin);
//     System.Console.WriteLine($"Максимальное значение=" + FindMax);
//     System.Console.WriteLine($"Разность между максимальным и минимальным элементом =" + DifferentMinMax);

// }

//Для Автотеста
//
//     {     // Введите свое решение ниже
// double max = array[0];
//         for (int i = 1; i < array.Length; i++)
//         {
//             if (max < array[i])
//             {
//                 max = array[i];
//             }
//         }
//         return max;


//     }

//     public static double FindMin(double[] array)
//     {     // Введите свое решение ниже
// double min = array[0];
//         for (int i = 1; i < array.Length; i++)
//         {
//             if (min > array[i])
//             {
//                 min = array[i];
//             }
//         }
//         return min;


//     }

//     public static double CalcDifferenceBetweenMaxMin(double[] array)
//     {// Введите свое решение ниже

// {
//         return FindMax(array) - FindMin(array);
//     }

//     }

//     public static void PrintArray(double[] array)
//     {// Введите свое решение ниже
// for (int i = 0; i < array.Length; i++)
//       {
//         Console.Write(array[i]);
//         if (i < array.Length - 1) // Проверяем, не последний ли элемент
//         {
//         Console.Write("\t"); // Добавляем табуляцию после всех элементов, кроме последнего
//         }
//       }
//         Console.WriteLine();

//     }

