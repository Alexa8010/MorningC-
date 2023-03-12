//Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2
//void DescentRow (int[,] array)
void DescentRow (int[,] array, int row)

{
    for (int i = 0; i < array.GetLength(1) - 1; i++)
    {
        for (int j = 0; j < array.GetLength(1) - i - 1; j++)
        {
            if (array[row,j + 1] > array[row,j])
            {
                int temp = array[row,j + 1];
                array[row,j + 1] = array[row,j];
                array[row,j] = temp;
            }
        }
    }
}    

// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             for (int k = 0; k < array.GetLength(1) - 1; k++)
//             {
//                 if (array[i,k] < array[i,k + 1])
//                 {
//                     int temp = array[i,k + 1];
//                     array[i,k + 1] = array[i,k];
//                     array[i,k] = temp;
//                 }
//             }
//         }
//     } 
// }            
int [,] CreateRandom2dArray (int rows, int colums, int minValue, int maxValue)
{   
 int[,] array = new int [rows, colums];

    for(int i = 0; i < rows; i++)
            for(int j = 0; j < colums; j++)
                 array[i,j] = new Random().Next(minValue, maxValue + 1); 

    return array;    
}
    
void Show2Array(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i,j] + " ");

        Console.WriteLine();

    }
    Console.WriteLine();
}

Console.Write("Input a number of rows: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a number of colums: ");
int colums = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a min possible value: ");
int minValue = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a max possible valies: ");
int maxValue = Convert.ToInt32(Console.ReadLine());

int[,] newArray = CreateRandom2dArray(rows, colums, minValue, maxValue);
Show2Array(newArray);
// DescentRow(newArray);
// Show2Array(newArray);

for(int i = 0; i < rows; i++)
{
    DescentRow(newArray, i);
}    
Show2Array(newArray);
  

