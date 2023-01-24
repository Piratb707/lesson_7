/*
Console.WriteLine("Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.");
Console.WriteLine("Нажмите клавишу Enter");
Console.ReadLine();

int m, n;

Console.WriteLine("Введите размер массива (m, n): ");
m = int.Parse(Console.ReadLine());
n = int.Parse(Console.ReadLine());

double[,] array = new double[m, n];
Random random = new Random();

for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        array[i, j] = random.NextDouble();
    }
}

Console.WriteLine("Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.");
Console.WriteLine("Нажмите клавишу Enter");
Console.ReadLine();

double[,] array = new double[m, n];
// Заполнение массива случайными значениями как в предыдущем примере

int x, y;
Console.WriteLine("Введите позицию элемента (x, y): ");
x = int.Parse(Console.ReadLine());
y = int.Parse(Console.ReadLine());

if (x < 0 || x >= m || y < 0 || y >= n)
{
    Console.WriteLine("Такого элемента нет в массиве");
}
else
{
    Console.WriteLine("Значение элемента: " + array[x, y]);
}

Console.WriteLine("Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.");
Console.WriteLine("Нажмите клавишу Enter");
Console.ReadLine();

int m, n;

Console.WriteLine("Введите размер массива (m, n): ");
m = int.Parse(Console.ReadLine());
n = int.Parse(Console.ReadLine());

int[,] array = new int[m, n];
Random random = new Random();

for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        array[i, j] = random.Next(0, 100);
    }
}

for (int j = 0; j < n; j++)
{
    double sum = 0;
    for (int i = 0; i < m; i++)
    {
        sum += array[i, j];
    }
    double avg = sum / m;
    Console.WriteLine("Среднее арифметическое элементов столбца " + (j+1) + ": " + avg);
}
*/