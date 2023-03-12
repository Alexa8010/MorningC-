//Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

int[,] ArrayMultiplication(int[,] array1, int[,] array2)
{
    int [,] array3 = new int [array1.GetLength(0), array2.GetLength(1)];
        
    for (int i = 0; i < array1.GetLength(0); i++)
    {
        for (int j = 0; j < array2.GetLength(1); j++)
        {
            array3 [i,j] = 0;
            for (int k = 0; k < array2.GetLength(0); k++)
            {
                array3[i, j] += array1[i, k] * array2[k, j];
            }
        }
    }
    return array3;
}
     

int [,] CreateRandom2dArray1 (int rows1, int colums1, int minValue1, int maxValue1)
{   
 int[,] array1 = new int [rows1, colums1];

    for(int i = 0; i < rows1; i++)
            for(int j = 0; j < colums1; j++)
                 array1[i,j] = new Random().Next(minValue1, maxValue1 + 1); 

    return array1;    
}

  int [,] CreateRandom2dArray2 (int rows2, int colums2, int minValue2, int maxValue2)
{   
 int[,] array2 = new int [rows2, colums2];

    for(int i = 0; i < rows2; i++)
            for(int j = 0; j < colums2; j++)
                 array2[i,j] = new Random().Next(minValue2, maxValue2 + 1); 

    return array2;    
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

Console.Write("Input a number of rows for the first matrix: ");
int rows1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a number of colums for the first matrix: ");
int colums1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a min possible value for the first matrix: ");
int minValue1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a max possible value for the first matrix: ");
int maxValue1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Input a number of rows for the second matrix (please mention that for the sucsessful multiplication this value should be equal to the value of colums for the first matrix): ");
int rows2 = Convert.ToInt32(Console.ReadLine());

if (colums1 != rows2)
{
    Console.Write("AAAAAAAA");
    return;
}

Console.Write("Input a number of colums for the second matrix: ");
int colums2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a min possible value for the second matrix: ");
int minValue2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a max possible value for the second matrix: ");
int maxValue2 = Convert.ToInt32(Console.ReadLine());

int[,] newArray1 = CreateRandom2dArray1(rows1, colums1, minValue1, maxValue1);
int[,] newArray2 = CreateRandom2dArray2(rows2, colums2, minValue2, maxValue2);
Show2Array(newArray1);
Show2Array(newArray2);

int[,] multipliedArray = ArrayMultiplication(newArray1, newArray2);
Show2Array(multipliedArray);