/* Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18 */

int ReadInput(string msg)
{
    Console.Write(msg);
    return Convert.ToInt32(Console.ReadLine());
}

void PrintArray(int[,] matr) //Функция для печати матрицы
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

void FillArray(int[,] matr, int a, int b)  //Функция для заполнения первого массива
{
    for (int i = 0; i < a; i++)
    {
        for (int j = 0; j < b; j++)
        {
            matr[i, j] = new Random().Next(1, 100);
        }
    }
}

int[,] ProductArray(int[,] matr1, int[,] matr2) // Функция нахождения произведения двух матриц
{
    var matr3 = new int[matr1.GetLength(0), matr2.GetLength(1)];
    if (matr1.GetLength(1) == matr2.GetLength(0))
    {
        for (int i = 0; i < matr3.GetLength(0); i++)
        {
            for (int j = 0; j < matr3.GetLength(1); j++)
            {
                matr3[i, j] = 0;
                for (int n = 0; n < matr1.GetLength(1); n++)
                {
                    matr3[i, j] += matr1[i, n] * matr2[n, j];
                }
            }
        }
    }
    return matr3;
}


int m = ReadInput("Введите число строк первой матрицы: ");
int n = ReadInput("Введите число столбцов первой матрицы: ");
int[,] firstmatrix = new int[m, n];
FillArray(firstmatrix, m, n);
PrintArray(firstmatrix);
Console.WriteLine();
int k = ReadInput("Введите число строк первой матрицы: ");
int l = ReadInput("Введите число столбцов первой матрицы: ");
int[,] secondmatrix = new int[k, l];
FillArray(secondmatrix, k, l);
PrintArray(secondmatrix);
Console.WriteLine();
Console.WriteLine("Результирующая матрица: ");
PrintArray(ProductArray(firstmatrix, secondmatrix));

