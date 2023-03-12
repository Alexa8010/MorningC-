// /Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2
// void DescentRow (int[,] array, int row)
// {
//     for (int i = 0; i < array.GetLength(1) - 1; i++)
//     {
//         for (int j = 0; j < array.GetLength(1) - i - 1; j++)
//         {
//             if (array[row,j + 1] > array[row,j])
//             {
//                 int temp = array[row,j + 1];
//                 array[row,j + 1] = array[row,j];
//                 array[row,j] = temp;
//             }
//         }
//     }
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

// int[,] newArray = CreateRandom2dArray(rows, colums, minValue, maxValue);
// Show2Array(newArray);

// for(int i = 0; i < rows; i++)
// {
//     DescentRow(newArray, i);
// }    
// Show2Array(newArray);
  
  
// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

// int GetSumRow (int[,] array, int row)
// {   
//     int sum = 0;
//     for(int j = 0; j < array.GetLength(1); j++) 
//         sum = sum + array[row,j]; 
//     return sum;    
// }

// int FindMinSum (int [] array)
// {
//     int indexMin = 0;
//     int index = 0;
//     for(index=0; index < array.Length; index++)
//     {
//         if(array[index] < array[indexMin])
//         indexMin = index;
//     }
//     return indexMin; 
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

// // void ShowArray (int [] array)
// // {
// //     for (int i=0; i < array.Length; i++)
// //     {
// //         Console.Write (array [i] + " ");
// //     }
// //     Console.WriteLine();
// // }

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

// int [] resultArray = new int[rows];

// for(int i = 0; i < rows; i++)
// {
//     resultArray[i] = GetSumRow(newArray, i);
// }

// int minSum = FindMinSum(resultArray);
// Console.WriteLine($"The row with the minimal sum is {minSum + 1}");
// ShowArray(resultArray);

//Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

// int[,] ArrayMultiplication(int[,] array1, int[,] array2)
// {
//     int [,] array3 = new int [array1.GetLength(0), array2.GetLength(1)];
        
//     for (int i = 0; i < array1.GetLength(0); i++)
//     {
//         for (int j = 0; j < array2.GetLength(1); j++)
//         {
//             array3 [i,j] = 0;
//             for (int k = 0; k < array2.GetLength(0); k++)
//             {
//                 array3[i, j] += array1[i, k] * array2[k, j];
//             }
//         }
//     }
//     return array3;
// }
     

// int [,] CreateRandom2dArray1 (int rows1, int colums1, int minValue1, int maxValue1)
// {   
//  int[,] array1 = new int [rows1, colums1];

//     for(int i = 0; i < rows1; i++)
//             for(int j = 0; j < colums1; j++)
//                  array1[i,j] = new Random().Next(minValue1, maxValue1 + 1); 

//     return array1;    
// }

//   int [,] CreateRandom2dArray2 (int rows2, int colums2, int minValue2, int maxValue2)
// {   
//  int[,] array2 = new int [rows2, colums2];

//     for(int i = 0; i < rows2; i++)
//             for(int j = 0; j < colums2; j++)
//                  array2[i,j] = new Random().Next(minValue2, maxValue2 + 1); 

//     return array2;    
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

// Console.Write("Input a number of rows for the first matrix: ");
// int rows1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input a number of colums for the first matrix: ");
// int colums1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input a min possible value for the first matrix: ");
// int minValue1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input a max possible value for the first matrix: ");
// int maxValue1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input a number of rows for the second matrix (please mention that for the sucsessful multiplication this value should be equal to the value of colums for the first matrix): ");
// int rows2 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input a number of colums for the second matrix: ");
// int colums2 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input a min possible value for the second matrix: ");
// int minValue2 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input a max possible value for the second matrix: ");
// int maxValue2 = Convert.ToInt32(Console.ReadLine());

// if (colums1 != rows2)
// {
//     Console.Write("The multiplication can not be performed as the number of colums of the first matrix is not equal to the number of rows of the second matrix");
//     return;
// }

// int[,] newArray1 = CreateRandom2dArray1(rows1, colums1, minValue1, maxValue1);
// int[,] newArray2 = CreateRandom2dArray2(rows2, colums2, minValue2, maxValue2);
// Show2Array(newArray1);
// Show2Array(newArray2);

// int[,] multipliedArray = ArrayMultiplication(newArray1, newArray2);
// Show2Array(multipliedArray);

// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

// bool ValueExistInArray(int[,,] array, int value)
// {
//     for(int i = 0; i < array.GetLength(0); i++)
//          for(int j = 0; j < array.GetLength(1); j++)
//              for(int k=0; k < array.GetLength(2); k++)
//                 if (array[i,j,k] == value)
//                     return true;

//     return false; 
// }

// void Show3Array(int[,,] array)
// {
//     for(int i = 0; i < array.GetLength(0); i++)
//     {
//         for(int j = 0; j < array.GetLength(1); j++)
//         {
//             for(int k = 0; k < array.GetLength(2); k++)
//                 Console.Write(array[i,j,k] + "(" + i + "," + j + "," + k + ") ");
//             Console.WriteLine();
//         }        
//         Console.WriteLine();
//     }
// }

// Console.Write("Input xd: ");
// int xd = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input yd: ");
// int yd = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input zd: ");
// int zd = Convert.ToInt32(Console.ReadLine());

// int[,,] resultArray = new int [xd, yd, zd];
// int randomValue = 0;
// if(xd * yd * zd > 90)
// {
//     Console.Write("Too big array");
//     return;
// }
// for(int i = 0; i < resultArray.GetLength(0); i++)
//     for(int j = 0; j < resultArray.GetLength(1); j++)
//         for(int k=0; k < resultArray.GetLength(2); k++)
//         {
//             randomValue = new Random().Next(10, 100); 
//             while(ValueExistInArray(resultArray, randomValue))
//                 randomValue = new Random().Next(10, 100);
//             resultArray[i,j,k] = randomValue; 
//         }

// Show3Array(resultArray);

