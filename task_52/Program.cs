// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

Console.WriteLine("Введите количество строк");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов");
int m = Convert.ToInt32(Console.ReadLine());

double[,] numbers = new double[n, m];
FillArrayRandomNumbers(numbers);
PrintArray(numbers);
AverageNum(numbers);
void FillArrayRandomNumbers(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 20);
        }
    }
}

void PrintArray(double[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (j != arr.GetLength(1) - 1)
                Console.Write($"|{arr[i, j]}|, ");
            else if (i == arr.GetLength(0) - 1 && j == arr.GetLength(1) - 1)
                Console.WriteLine($"|{arr[i, j]}|");
            else if (j == arr.GetLength(1) - 1)
                Console.WriteLine($"|{arr[i, j]}|,");
        }
    }
}

void AverageNum(double[,] mas)
{
    for (int j = 0; j < numbers.GetLength(1); j++)
    {
        double average = 0;
        for (int i = 0; i < numbers.GetLength(0); i++)
        {
            average = (average + numbers[i, j]);
        }
        average = average / n;
        Console.Write(average + "; ");
    }
}