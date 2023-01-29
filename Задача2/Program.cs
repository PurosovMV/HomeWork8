/* Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
 */

int ReadInput(string msg)
{
    Console.Write(msg);
    return Convert.ToInt32(Console.ReadLine());
}

void PrintArray(int[,] matr) //Функция печати матрицы
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]} ");
        }
        Console.WriteLine();
    }
}

void FillArray(int[,] matr, int a, int b) //Функция заполнения матрицы
{
    for (int i = 0; i < a; i++)
    {
        for (int j = 0; j < b; j++)
        {
            matr[i, j] = new Random().Next(1, 100);
        }
    }
}

void Product(int[,] matr) //Функция подсчёта суммы элементов в каждой строке и выдачи номера строки с наименьшей суммой элементов
{
    int index = 0, minsum = 0;
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        {
            int sum = 0;
            for (int j = 0; j < matr.GetLength(1); j++)
            {
                sum += matr[i, j];
            }
            if (i == 0)
            {
                minsum = sum;
            }
            else if (sum < minsum)
            {
                minsum = sum;
                index = i;
            }
        }
    }
    Console.WriteLine();
    Console.WriteLine($"Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: {index + 1} строка. ");
}

int m = ReadInput("Введите число строк матрицы: ");
int n = ReadInput("Введите число столбцов матрицы: ");
int[,] newmatrix = new int[m, n];
FillArray(newmatrix, m, n);
PrintArray(newmatrix);
Product(newmatrix);



