// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2

// 1, -7, 567, 89, 223-> 3


// int ShowQuantOfPositiveNumbers (int [] array)
// {
//    int counter = 0;
//    for (int i = 0; i < array.Length; i++) 
//     {
//         if (array[i] > 0) counter++;
//     }
//     return counter;
// }
// int [] CreateArray (int M)
//  {
//      int [] array = new int [M];
//      for (int i = 0; i < M; i++)
//      {
//         Console.WriteLine($"Input element {i}");
//         array[i] = Convert.ToInt32 (Console.ReadLine());
//      }
       
//  return array;
//  }
// void ShowArray (int [] array)
// {
//     for (int i=0; i < array.Length; i++)
//             Console.Write (array [i] + " ");
//     Console.WriteLine();
// }


// Console.Write ("Input M: ");
// int M = Convert.ToInt32 (Console.ReadLine());

// int [] array = CreateArray (M);
// ShowArray(array);
// int numOfPosNum = ShowQuantOfPositiveNumbers(array);
// Console.WriteLine($"Num of positive integer = {numOfPosNum}");


// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)


// Console.Write ("Input k1: ");
// double k1 = Convert.ToDouble (Console.ReadLine());
// Console.Write ("Input b1: ");
// double b1 = Convert.ToDouble (Console.ReadLine());
// Console.Write ("Input k2: ");
// double k2 = Convert.ToDouble (Console.ReadLine());
// Console.Write ("Input b2: ");
// double b2 = Convert.ToDouble (Console.ReadLine());

// if (k1 != k2)
// {
//         double x = (b2 - b1) / (k1 - k2);
//         double y = (k1 * (b2 - b1) / (k1 -k2)) + b1;
//         Console.WriteLine ($" прямые y = {k1} * x + {b1} и y = {k2} * x + {b2} пересекаются в точке ({x}; {y})]");
// }
// else
//     if (k1 == k2 && b1 != b2)
//     Console.WriteLine ($" прямые y = {k1} * x + {b1} и y = {k2} * x + {b2} параллельны и не имеют точек пересечения");
// else
//     Console.WriteLine ($" прямые y = {k1} * x + {b1} и y = {k2} * x + {b2} накладываются друг на друга и пересекаются во всех точках");
    