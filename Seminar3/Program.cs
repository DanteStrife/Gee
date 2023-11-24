/// Задача №17. Напишите программу, которая принимает на 
// вход координаты точки (X и Y), 
// причем X ≠ 0 и Y ≠ 0 и выдаёт номер четверти 
// плоскости, в которой находится эта точка.

// Console.WriteLine("Введите число");
// int x = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите число");
// int y = int.Parse(Console.ReadLine());

// if(x>0 && y>0)
// {
//     Console.WriteLine("1");
// }
// else if(x<0 && y>0)
// {
//     Console.WriteLine("2");
// }
// else if(x<0 && y<0)
// {
//     Console.WriteLine("3");
// }
// else
// {
//     Console.WriteLine("4");
// }


///Напишите программу, которая по заданному 
// номеру четверти, показывает диапазон возможных
//  координат точек в этой четверти (x и y).

// Console.WriteLine("Введите число");
// int num = Convert.ToInt32(Console.ReadLine());

// switch (num)
// {
//     case 1:
//     {
//         Console.WriteLine("x>0  y>0");
//         break;
//     }
//     case 2:
//     {
//         Console.WriteLine("x<0  y>0");
//         break;
//     }
//     case 3:
//     {
//         Console.WriteLine("x<0  y<0");
//         break;
//     }
//     case 4:
//     {
//         Console.WriteLine("x>0  y<0");
//         break;
//     }
//     default:
//     {
//         Console.WriteLine("Нет такой четверти");
//         break;
//     }
// }



// / char ch;
//             Console.WriteLine("Введите букву");
//             ch = Convert.ToChar(Console.ReadLine());
 
//             switch(Char.ToLower(ch))
//             {
//                 case 'а':                      
//                 case 'у':                      
//                 case 'о':                      
//                 case 'ы':                      
//                 case 'и':
//                 case 'э':                                            
//                 case 'я':                                            
//                 case 'ю':                      
//                 case 'е':                                           
//                 case 'ё':
//                     Console.WriteLine("Гласная");
//                     break;
//                 default:
//                     Console.WriteLine("Согласная");
//                     break;
//             }


/// Напишите программу, которая принимает на вход
//  координаты двух точек и находит расстояние между
//   ними в 2D пространстве.

// A (3,6); B (2,1) -> 5,09 
// A (7,-5); B (1,-1) -> 7,21

// Console.WriteLine("Введите число");
// int x1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите число");
// int y1 = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите число");
// int x2 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите число");
// int y2 = Convert.ToInt32(Console.ReadLine());

// double s= Math.Sqrt(Math.Pow((x2-x1),2) + Math.Pow((y2-y1),2));

// Console.WriteLine(s);


/// Напишите программу, которая принимает на вход 
// число (N) и выдаёт таблицу квадратов чисел 
// от 1 до N.

// 5 -> 1, 4, 9, 16, 25.
// 2 -> 1,4


// // Через цикл for

// Console.WriteLine("Введите число");
// int num = Convert.ToInt32(Console.ReadLine());

// for(int i =1; i<=num; i++)
// {
//     Console.WriteLine(Math.Pow(i,2)+ " ");
// }

// // Через цикл while

// int i = 1;

// while(i<=num)
// {
//     Console.Write(Math.Pow(i,2)+ " ");
//     i++;
// }

// // Еще один вариант

// for(double i = 1; i<=num; i++)
// {
//     double  result = Math.Pow(i,2);

//     Console.Write(result+ " ");
// }


