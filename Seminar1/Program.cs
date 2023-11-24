///Задача №1.Напишите программу, которая на вход 
    // принимает число и выдает его квадрат (число умноженное 
    // на само себя).

    // Например:
    // 4 -> 16 
    // -3 -> 9 
    // -7 -> 49

    // Console.WriteLine("Введите число");
    // int num = Convert.ToInt32(Console.ReadLine());

    // int result = num *num;

    // Console.WriteLine(result);


/// Задача №2. Напишите программу, 
    // которая на вход принимает два 
    // числа и проверяет, является ли первое
    //  число квадратом второго.
    // a = 25, b = 5 -> да 
    // a = 2, b = 10 -> нет 
    // a = 9, b = -3 -> да 
    // a = -3 b = 9 -> нет

    // Console.WriteLine("Введите число");
    // int num1 = Convert.ToInt32(Console.ReadLine());

    // Console.WriteLine("Введите число");
    // int num2 = Convert.ToInt32(Console.ReadLine());

    // if(num1== num2*num2)
    // {
    //     Console.WriteLine("Да");
    // }
    // else
    // {
    //      Console.WriteLine("Нет");
    // }


/// Задача №3. Напишите программу, которая
    //  будет выдавать название дня недели 
    //  по заданному номеру.
    // 3 -> Среда 
    // 5 -> Пятница

    // Console.WriteLine("Введите число");
    // int num1 = Convert.ToInt32(Console.ReadLine());

    // if(num1 == 1)
    // {
    //     Console.WriteLine("Понедельник");
    // }
    // else if(num1 == 2)
    // {
    //     Console.WriteLine("Вторник");
    // }
    // else if(num1 == 3)
    // {
    //     Console.WriteLine("Среда");
    // }
    // else if(num1 == 4)
    // {
    //     Console.WriteLine("Четверг");
    // }
    // else if(num1 == 5)
    // {
    //     Console.WriteLine("Пятница");
    // }
    // else if(num1 == 6)
    // {
    //     Console.WriteLine("Субота");
    // }
    // else if(num1 == 7)
    // {
    //     Console.WriteLine("Воскресенье");
    // }
    // else
    // {
    //     Console.WriteLine("введите другое число");
    // }

/// Задача №5. Напишите программу, которая 
    // // на вход принимает одно число (N), а на 
    // // выходе показывает все целые числа в промежутке от -N до N.
    // // 4 -> "-4, -3, -2, -1, 0, 1, 2, 3, 4" 
    // // 2 -> " -2, -1, 0, 1, 2"

    // Console.WriteLine("Введите число");
    // int num = Convert.ToInt32(Console.ReadLine());

    // int negNum = num * -1;

    // while(negNum<=num)
    // {
    //     Console.WriteLine(negNum);
    //     negNum = negNum+1;
    // }


/// Задача №7. Напишите программу, которая 
    // принимает на вход трёхзначное число и на
    //  выходе показывает последнюю цифру этого числа.
    // 	456 -> 6
    // 	782 -> 2
    // 	918 -> 8

    // Console.WriteLine("Введите число");
    // int num = Convert.ToInt32(Console.ReadLine());

    // int result = num % 10;
    // Console.WriteLine("Нужное число" + result + "пнгр");  //Канкатинация

    // Console.WriteLine($"Нужное число  {result}  пнгр");   // Интерполяция


/// ДЗ Автотест 1
    // Внутри класса Answer напишите метод CompareNumbers, который на вход принимает два числа и выводит,
    //  какое число большее, а какое меньшее.

    // Console.WriteLine("Введите число");
    // int firstNumber = Convert.ToInt32(Console.ReadLine());
    // Console.WriteLine("Введите число");
    // int secondNumber = Convert.ToInt32(Console.ReadLine());

    // if(firstNumber < secondNumber)
    // {
    //     Console.WriteLine($"Первое число '{firstNumber}' меньше чем второе число '{secondNumber}'");
    // }
    // else if(firstNumber>secondNumber)
    // {
    //     Console.WriteLine($"Первое число '{firstNumber}' больше чем второе число '{secondNumber}'");
    // }
    // else if(firstNumber==secondNumber)
    // {
    //     Console.WriteLine($"Числа '{firstNumber}' и '{secondNumber}' равны.");
    // }

///ДЗ Автотест 2
    // Внутри класса Answer напишите метод FindMax, который принимает на вход три числа и выдаёт максимальное из этих чисел.

    // int a = Convert.ToInt32(Console.ReadLine());
    // int b = Convert.ToInt32(Console.ReadLine());
    // int c = Convert.ToInt32(Console.ReadLine());
    // int max = a;
    // if (b > max)
    // {
    // max = b;
    // }
    // if (c > max)
    // {
    // max = c;
    // }
    // {
    // Console.WriteLine(max);
    // }
    //     return max;

/// ДЗ Автотест 3
    // Внутри класса Answer напишите метод CheckIfEven, который на вход принимает число number и выводит,
    //  является ли число чётным (делится ли оно на два без остатка).

    // int number = Convert.ToInt32(Console.ReadLine());
    // if ((number%2)==0)
    // {
    // Console.WriteLine($"Число `{number}` чётное");
    // }
    // else 
    // {
    // Console.WriteLine($"Число `{number}` нечётное");
    // }
    // {
    // Console.WriteLine(number);
    // }

/// ДЗ Автотест 4
    // Внутри класса Answer напишите метод PrintEvenNumbers, которая на вход принимает число (number),
    //  а на выходе выводит все чётные числа от 1 до number (включительно), разделеные знаком табуляции


    //     Console.WriteLine("Введите число");
    //     int number = Convert.ToInt32(Console.ReadLine());
    //     int numberx = 1;
    //     while(numberx <= number)
    //         {
    //         if (numberx % 2 == 0)
    //         Console.Write(numberx + "\t");
    //         numberx++;
    //         }


