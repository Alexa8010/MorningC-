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

