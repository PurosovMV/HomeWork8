/* Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2
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

void Product(int[,] matr) //Функция сортировки элементов строк матрицы по убыванию
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            for (int k = 0; k < matr.GetLength(1) - 1; k++)
            {
                if (matr[i, k] < matr[i, k + 1])
                {
                    int temp = matr[i, k + 1];
                    matr[i, k + 1] = matr[i, k];
                    matr[i, k] = temp;
                }

            }

        }
    }
}


int m = ReadInput("Введите число строк матрицы: ");
int n = ReadInput("Введите число столбцов матрицы: ");
int[,] newmatrix = new int[m, n];
FillArray(newmatrix, m, n);
PrintArray(newmatrix);
Console.WriteLine();
Product(newmatrix);
PrintArray(newmatrix);