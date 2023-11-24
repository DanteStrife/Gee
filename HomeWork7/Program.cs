
/// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// Внутри класса Answer напишите метод CreateRandomMatrix, который принимал бы
// числа m и n (размерность массива), а также minLimitRandom и maxLimitRandom, 
// которые указывают на минимальную и максимальную границы случайных чисел.

// Также, задайте метод PrintArray, который выводил бы массив на экран.

// Для вывода матрица используйте интерполяцию строк для форматирования числа 
// matrix[i, j] с двумя знаками после запятой (f2) и добавления символа 
// табуляции (\t) после каждого элемента матрицы. Таким образом, каждый 
// элемент матрицы будет разделен символом табуляции при выводе.



// Console.WriteLine("Создаем двумерный массив.");


// Console.Write("Введите число строк. ");
// int m = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите столбцов. ");
// int n = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите минимальное значение в массиве. ");
// int minLimitRandom = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите максимальное значенние в массиве. ");
// int maxLimitRandom = Convert.ToInt32(Console.ReadLine());

// double[,] CreateRandomMatrix() // Создание массива со случайными вещественными числами
// {
//     double[,] matrix = new double[m, n];
//     Random rand = new Random();
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             matrix[i, j] = Math.Round(rand.Next(minLimitRandom * 10, maxLimitRandom * 10) * 0.1, 2);
//         }
//     }

//     return matrix;
// }

// void PrintArray(double[,] matrix) //Вывод массива
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             System.Console.Write( "{0,6:F2} \t", matrix[i, j]);
//         }
//         System.Console.WriteLine();
//     }
// }

// System.Console.WriteLine($"m = {m}, n = {n}, minLimitRandom = {minLimitRandom}, maxLimitRandom = {maxLimitRandom}");
// System.Console.WriteLine();


// double[,] arrayResult = CreateRandomMatrix(); // создаем пустой массив и кладем в него другой
// PrintArray(arrayResult); // вызов массива


///Внутри класса Answer напишите методы CreateIncreasingMatrix, PrintArray, 
// FindNumberByPosition и PrintCheckIfError.

// Метод CreateIncreasingMatrix должен создавать матрицу заданной размерности, 
// с каждым новым элементом увеличивающимся на определенное число. Метод 
// принимает на вход три числа (n - количество строк матрицы, m - количество 
// столбцов матрицы, k - число, на которое увеличивается каждый новый элемент) 
// и возвращает матрицу, удовлетворяющую этим условиям.

// Метод PrintArray должен выводить на экран сгенерированную методом 
// CreateIncreasingMatrix матрицу. Элементы матрицы должны быть 
// выведены через символ табуляции для более читаемого вывода.

// Метод FindNumberByPosition принимает на вход сгенерированную матрицу 
// и числа x и y - позиции элемента в матрице. Если указанные координаты 
// находятся за пределами границ массива, метод должен вернуть массив 
// с нулевым значением. Если координаты находятся в пределах границ, 
// метод должен вернуть массив с двумя значениями: значением числа в 
// указанной позиции, а второй элемент должен быть равен 0, чтобы показать, 
// что операция прошла успешно без ошибок.

// Метод PrintCheckIfError должен принимать результат метода 
// FindNumberByPosition и числа x и y - позиции элемента в матрице. 
// Метод должен проверить, был ли найден элемент в матрице по указанным 
// координатам (x и y), используя результаты из метода FindNumberByPosition. 
// Если такого элемента нет, вывести на экран "There is no such index". 
// Если элемент есть, вывести на экран "The number in [{x}, {y}] is {значение}".


// Console.WriteLine("Создаем двумерный массив.");


// Console.Write("Введите число строк. ");
// int n = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите столбцов. ");
// int m = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите значение, на которое изменяется следующий элемент массива. ");
// int k = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите значение x. ");
// int x = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите значение y. ");
// int y = Convert.ToInt32(Console.ReadLine());

// int num = 1;

// int[,] CreateIncreasingMatrix() 
// {
//     int[,] matrixGen = new int[n, m];
//     for (int i = 0; i < n; i++)
//     {
//         for (int j = 0; j < m; j++)
//         {
//             if (i == 0 && j == 0) { matrixGen[i, j] = 1; }
//             else if (j != 0) { matrixGen[i, j] = matrixGen[i, j - 1] + k; }
//         }
//         if (i < n - 1) { matrixGen[i + 1, 0] = matrixGen[i, m - 1] + k; }
//     }
//     return matrixGen;
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

// int[] FindNumberByPosition(int[,] matrix, int rowPosition, int columnPosition)

// {
//     int[] number = new int[2];
//     if (rowPosition >= 0 && rowPosition < matrix.GetLength(0) && columnPosition >= 0 && columnPosition < matrix.GetLength(1))
//     {
//         number[1] = 0;
//         number[0] = matrix[rowPosition, columnPosition];
//     }
//     return number;
// }

// void PrintCheckIfError(int[] results, int X, int Y)
// {
//     int i = results[0];
//     if (i == 0)
//         System.Console.WriteLine("There is no such index");
//     else
//         System.Console.WriteLine($"The number in [{X}, {Y}] is {i}");
//     return;

// }



// int[,] arrayResult = CreateIncreasingMatrix(); // создаем пустой массив и кладем в него другой
// PrintArray(arrayResult); // вызов массива
// PrintCheckIfError(FindNumberByPosition(arrayResult, x, y), x, y);


/// Внутри класса Answer напишите методы CreateIncreasingMatrix, 
// PrintArray, PrintListAvr и FindAverageInColumns.

// Метод CreateIncreasingMatrix должен создавать матрицу 
// заданной размерности, с каждым новым элементом увеличивающимся 
// на определенное число. Метод принимает на вход 
// три числа (n - количество строк матрицы, m - количество 
// столбцов матрицы, k - число, на которое увеличивается 
// каждый новый элемент) и возвращает матрицу, удовлетворяющую 
// этим условиям.

// Метод PrintArray должен выводить на экран сгенерированную 
// методом CreateIncreasingMatrix матрицу.

// Метод FindAverageInColumns принимает целочисленную 
// матрицу типа int[,] и возвращает одномерный массив 
// типа double. Этот метод вычисляет среднее значение 

// Метод PrintListAvr принимает одномерный массив, 
// возвращенный методом FindAverageInColumns и выводит 
// этот список на экран в формате
// The averages in columns are:
// x.x0 x.x0 x.x0 ..., где x.x0 - это значения средних 
// значений столбцов, округленные до двух знаков после 
// запятой (в дробной части ВСЕГДА должно быть 2 числа 
// через точку, см. формат вывода), разделенные знаком 
// табуляции.


Console.WriteLine("Создаем двумерный массив.");


Console.Write("Введите число строк. ");
int n = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите столбцов. ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите значение, на которое изменяется следующий элемент массива. ");
int k = Convert.ToInt32(Console.ReadLine());

int[,] CreateIncreasingMatrix()
{
    int[,] matrixGen = new int[n, m];
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < m; j++)
        {
            if (i == 0 && j == 0) { matrixGen[i, j] = 1; }
            else if (j != 0) { matrixGen[i, j] = matrixGen[i, j - 1] + k; }
        }
        if (i < n - 1) { matrixGen[i + 1, 0] = matrixGen[i, m - 1] + k; }
    }
    return matrixGen;
}

void PrintArray(int[,] matrix) //Вывод массива
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            System.Console.Write(matrix[i, j] + "\t");
        }
        System.Console.WriteLine();
    }
}


double[] FindAverageInColumns(int[,] matrix)
{
    double[] AverageInColumns = new double[matrix.GetLength(1)];
    AverageInColumns[0] = 0;
    for (int column = 0; column < matrix.GetLength(1); column++)
    {
        for (int row = 0; row < matrix.GetLength(0); row++)
        { AverageInColumns[column] += matrix[row, column]; }
        AverageInColumns[column] = AverageInColumns[column] / matrix.GetLength(0);
    }
    return AverageInColumns;
}

void PrintListAvr(double[] list)
{
    Console.WriteLine("The averages in columns are:");
    for (int b = 0; b < list.GetLength(0); b++)
    {
        Console.Write($"{list[b].ToString("0.00")}\t");
    }
    Console.WriteLine();
}

int[,] result = CreateIncreasingMatrix();
PrintArray(result);
PrintListAvr(FindAverageInColumns(result));

// int[,] arrayResult = CreateIncreasingMatrix(); // создаем пустой массив и кладем в него другой
// PrintArray(arrayResult); // вызов массива
// PrintCheckIfError(FindNumberByPosition(arrayResult, x, y), x, y);