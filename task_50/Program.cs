// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

// Console.Write("Введите строку: ");
// int pos1 = Convert.ToInt32(Console.ReadLine()) - 1;
// Console.Write("Введите столбец: ");
// int pos2 = Convert.ToInt32(Console.ReadLine()) - 1;
// int n = 5;
// int m = 7;
// Random random = new Random();
// int[,] arr = new int[n, m];
// Console.WriteLine("Исходный массив: ");
// for (int i = 0; i < arr.GetLength(0); i++)
// {
//     for (int j = 0; j < arr.GetLength(1); j++)
//     {
//         arr[i, j] = random.Next(10, 99);
//         Console.Write(arr[i, j]);
//     }
//     Console.WriteLine();
// }
// if (pos1 < 0 | pos1 > arr.GetLength(0) - 1 | pos2 < 0 | pos2 > arr.GetLength(1) - 1)
// {
//     Console.WriteLine("Элемент не существует  ");
// }
// else
// {
//     Console.WriteLine($"Значение элемента массива = {0}", arr[pos1, pos2]);
// }

Console.WriteLine("Введите количество строк в массиве: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов в массиве: ");
int n = Convert.ToInt32(Console.ReadLine());
int[,] array = new int[m, n];
 
for (int i = 0; i < array.GetLength(0); i++) 
{
    for (int j = 0; j < array.GetLength(0); j++)
        array [i, j] = Convert.ToInt32(new Random().Next(0, 21));  
}
 
for (int i = 0; i < array.GetLength(0); i++) 
{
    for (int j = 0; j < array.GetLength(1); j++)
        Console.Write(array[i, j] + "\t  ");
        Console.WriteLine();}
 
 Console.WriteLine("Введите номер строки: ");
 int a = Convert.ToInt32(Console.ReadLine());
 Console.WriteLine($"Строка № {a}");
 Console.WriteLine("Введите номер столбца: ");
 int b = Convert.ToInt32(Console.ReadLine());
 Console.WriteLine($"Стролбец № {b}");
 if (a>m && b>n)
 Console.WriteLine("Такого числа нет");
 else
 {
 object c = array.GetValue(a, b);
 Console.WriteLine(c);
 }