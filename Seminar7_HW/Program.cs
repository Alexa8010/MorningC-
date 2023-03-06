// // Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// // m = 3, n = 4.

// // 0,5 7 -2 -0,2

// // 1 -3,3 8 -9,9

// // 8 7,8 -7,1 9

// double [,] CreateRandom2dArray (int rows, int colums, double minValue, double maxValue)
// {   
//     double[,] array = new double [rows, colums];

//     for(int i = 0; i < rows; i++)
//             for(int j = 0; j < colums; j++)
//                 array[i,j] = (new Random().NextDouble())*(maxValue - minValue) + minValue; 

//     return array;    
// }

// void Show2Array(double[,] array)
// {
//     for(int i = 0; i < array.GetLength(0); i++)
//     {
//         for(int j = 0; j < array.GetLength(1); j++)
//             Console.Write(Math.Round(array[i,j],2) + " ");

//         Console.WriteLine();

//     }
//     Console.WriteLine();
// }

// Console.Write("Input a number of rows: ");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input a number of colums: ");
// int colums = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input a min possible value: ");
// double minValue = Convert.ToDouble(Console.ReadLine());
// Console.Write("Input a max possible valies: ");
// double maxValue = Convert.ToDouble(Console.ReadLine());

// double[,] newArray = CreateRandom2dArray(rows, colums, minValue, maxValue);
// Show2Array(newArray);

 
// // Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

// // Например, задан массив:

// // 1 4 7 2

// // 5 9 2 3

// // 8 4 2 4

// // 1 7 -> элемента с такими индексами в массиве нет

// void FindNumber (int[,] array, int rowNum, int columNum)
// {
//         if (rowNum < array.GetLength(0) && columNum <  array.GetLength(1)) 
//         {
//             Console.WriteLine($"The number with indexes[{rowNum},{columNum}] is {array[rowNum,columNum]}");
//         }    
//         else
//             Console.WriteLine($"The number with indexes[{rowNum},{columNum}] does not exist in the array");   
// }

// int [,] CreateRandom2dArray (int rows, int colums, int minValue, int maxValue)
// {   
//  int[,] array = new int [rows, colums];

//     for(int i = 0; i < rows; i++)
//             for(int j = 0; j < colums; j++)
//                  array[i,j] = new Random().Next(minValue, maxValue + 1); 

//     return array;    
// }

// void Show2Array(int[,] array)
// {
//     for(int i = 0; i < array.GetLength(0); i++)
//     {
//         for(int j = 0; j < array.GetLength(1); j++)
//             Console.Write(array[i,j] + " ");

//         Console.WriteLine();

//     }
//     Console.WriteLine();
// }

// Console.Write("Input a number of rows: ");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input a number of colums: ");
// int colums = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input a min possible value: ");
// int minValue = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input a max possible valies: ");
// int maxValue = Convert.ToInt32(Console.ReadLine());

// Console.Write("Input a row of a number (please mention that numeration of rows starts with 0): ");
// int rowNum = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input a colum of a number (please mention that numeration of colums starts with 0): ");
// int columNum = Convert.ToInt32(Console.ReadLine());

// int[,] newArray = CreateRandom2dArray(rows, colums, minValue, maxValue);
// Show2Array(newArray);
// FindNumber(newArray, rowNum, columNum);


// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

// double GetColumAvg (int[,] array, int col)
// {   
//     double sum = 0;
    
//     for(int i = 0; i < array.GetLength(0); i++) 
//         sum = sum + array[i,col]; 

//     return sum/array.GetLength(0);    
// }
 

// int [,] CreateRandom2dArray (int rows, int colums, int minValue, int maxValue)
// {   
//  int[,] array = new int [rows, colums];

//     for(int i = 0; i < rows; i++)
//             for(int j = 0; j < colums; j++)
//                  array[i,j] = new Random().Next(minValue, maxValue + 1); 

//     return array;    
// }

  

// void Show2Array(int[,] array)
// {
//     for(int i = 0; i < array.GetLength(0); i++)
//     {
//         for(int j = 0; j < array.GetLength(1); j++)
//             Console.Write(array[i,j] + " ");

//         Console.WriteLine();

//     }
//     Console.WriteLine();
// }

// void ShowArray (double [] array)
// {
//     for (int i=0; i < array.Length; i++)
//     {
//         Console.Write (array [i] + " ");
//     }
//     Console.WriteLine();
// }

// Console.Write("Input a number of rows: ");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input a number of colums: ");
// int colums = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input a min possible value: ");
// int minValue = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input a max possible valies: ");
// int maxValue = Convert.ToInt32(Console.ReadLine());

// int[,] newArray = CreateRandom2dArray(rows, colums, minValue, maxValue);
// Show2Array(newArray);

// double [] resultArray = new double[colums];

// for(int j = 0; j < colums; j++)
// {
//     resultArray[j] = GetColumAvg(newArray, j);
// }
// ShowArray(resultArray);