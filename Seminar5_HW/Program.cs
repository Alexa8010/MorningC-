// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

// int EvenNumbQuant (int[] array)
// {
//     int counter = 0;
//     for (int i = 0; i < array.Length; i++)
//             if (array[i] % 2 == 0) counter++;       
//     return counter;
// }

// int [] CreateRandomArray (int size, int minValue, int maxValue)
// {
//     int [] array = new int [size];
//     for (int i = 0; i < size; i++)
//             array [i] = new Random().Next(100, 1000);
       
// return array;
// }

// void ShowArray (int [] array)
// {
//     for (int i=0; i < array.Length; i++)
//             Console.Write (array [i] + " ");
//         Console.WriteLine();
// }
// Console.Write ("Input a quantity of elements: ");
// int size = Convert.ToInt32 (Console.ReadLine());
// Console.Write ("Input a min value >= 100: ");
// int min = Convert.ToInt32 (Console.ReadLine());
// Console.Write ("Input a max value < 1000: ");
// int max = Convert.ToInt32 (Console.ReadLine());

// int [] newArray = CreateRandomArray (size, min, max);
// ShowArray(newArray);
// int evenQuant = EvenNumbQuant(newArray);
// Console.WriteLine ($"The quantity of even numbers in the array is {evenQuant}");

// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
//Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0
// int SumOfOddIndexes (int[] array)
// {
//     int sum = 0;
//     for (int i = 1; i < array.Length; i = i + 2)
//          sum += array[i];
//     return sum;
// }

// int [] CreateRandomArray (int size, int minValue, int maxValue)
// {
//     int [] array = new int [size];
//     for (int i = 0; i < size; i++)
//             array [i] = new Random().Next(minValue, maxValue + 1);
       
// return array;
// }

// void ShowArray (int [] array)
// {
//     for (int i=0; i < array.Length; i++)
//             Console.Write (array [i] + " ");
//         Console.WriteLine();
// }
// Console.Write ("Input a quantity of elements: ");
// int size = Convert.ToInt32 (Console.ReadLine());
// Console.Write ("Input a min value: ");
// int min = Convert.ToInt32 (Console.ReadLine());
// Console.Write ("Input a max value: ");
// int max = Convert.ToInt32 (Console.ReadLine());

// int [] newArray = CreateRandomArray (size, min, max);
// ShowArray(newArray);
// int sumOfOdds = SumOfOddIndexes(newArray);
// Console.WriteLine ($"The sum of numbers with odd indexes in the array is {sumOfOdds}");

// Задача 38: Задайте массив вещественных чисел. 
//Найдите разницу между максимальным и минимальным элементов массива.
// // [3 7 22 2 78] -> 76
// double MaxValue (double[] array)
// {
//     int indexMax = 0;
//     for (int i = 1; i < array.Length; i++)
//          if (array[i] > array[indexMax])
//              indexMax = i;
//     return array[indexMax];
// }
// double MinValue (double[] array)
// {
//     int indexMin = 0;
//     for (int i = 1; i < array.Length; i++)
//          if (array[i] < array[indexMin])
//             indexMin = i;
//     return array[indexMin];
// }
// double [] CreateRandomArray (int size, double minValue, double maxValue)
// {
//     double [] array = new double [size];
//     for (int i = 0; i < size; i++)
//             array [i] = (new Random().NextDouble())*(maxValue - minValue) + minValue;
       
// return array;
// }

// void ShowArray (double [] array)
// {
//     for (int i=0; i < array.Length; i++)
//             Console.Write (array [i] + " ");
//         Console.WriteLine();
// }

// Console.Write ("Input a quantity of elements: ");
// int size = Convert.ToInt32 (Console.ReadLine());
// Console.Write ("Input a min value: ");
// double min = Convert.ToDouble (Console.ReadLine());
// Console.Write ("Input a max value: ");
// double max = Convert.ToDouble (Console.ReadLine());

// double [] newArray = CreateRandomArray (size, min, max);

// ShowArray(newArray);
// double maximum = MaxValue(newArray);
// double minimum = MinValue(newArray);
// double diff = maximum - minimum;
// Console.WriteLine ($"The difference  betweem the maximal {maximum} and the minimal {minimum} values of the array is {diff}");
