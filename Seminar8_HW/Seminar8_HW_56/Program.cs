// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

int GetSumRow (int[,] array, int row)
{   
    int sum = 0;
    
    for(int j = 0; j < array.GetLength(1); j++) 
        sum = sum + array[row,j]; 
    return sum;    
}

int FindMinSum (int [] array)
{
    int indexMin = 0;
    int index = 0;
    for(index=0; index < array.Length; index++)
    {
        if(array[index] < array[indexMin])
        indexMin = index;
    }
    return indexMin; 
} 

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

void ShowArray (int [] array)
{
    for (int i=0; i < array.Length; i++)
    {
        Console.Write (array [i] + " ");
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

int [] resultArray = new int[rows];

for(int i = 0; i < rows; i++)
{
    resultArray[i] = GetSumRow(newArray, i);
}

int minSum = FindMinSum(resultArray);
Console.WriteLine($"The row with the minimal sum is {minSum + 1}");
ShowArray(resultArray);





