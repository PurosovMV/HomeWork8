/* Задача 62.Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07 */

int ReadInput(string msg)
{
    Console.Write(msg);
    return Convert.ToInt32(Console.ReadLine());
}

void PrintArray(int[,] matr) //Функция печати массива
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            if (matr[i, j] < 10)
            {
                Console.Write("0" + matr[i, j]);
                Console.Write(" ");
            }
            else Console.Write(matr[i, j] + " ");
        }
        Console.WriteLine();
    }
}

void FillArray(int[,] matr, int a) //Функция заполнения массива
{
    int i = 0, j = 0;
    int count = 1;
    for (int b = 0; b <= a * a + 1; b++)
    {
        int k = 0;
        do
        {
            matr[i, j++] = count++;
        }
        while (++k < a - 1);
        for (k = 0; k < a - 1; k++) matr[i++, j] = count++;
        for (k = 0; k < a - 1; k++) matr[i, j--] = count++;
        for (k = 0; k < a - 1; k++) matr[i--, j] = count++;
        ++i; ++j;
        a = a < 2 ? 0 : a - 2;
    }
}



int n = ReadInput("Введите размерность (n) квадратной матрицы n x n: ");

int[,] newmatrix = new int[n, n];
FillArray(newmatrix, n);
PrintArray(newmatrix);
