/* Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив,
добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1) */


int ReadInput(string msg)
{
    Console.Write(msg);
    return Convert.ToInt32(Console.ReadLine());
}

void PrintArray(int[,,] matrix) //Функция печати 3D массива
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                Console.Write($"{matrix[i, j, k],1}({i},{j},{k})  ");
            }
            Console.WriteLine();
        }
    }
}

void FillArray(int[,,] matr) //Функция заполнения 3D массива
{
    int count = 1;
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            for (int k = 0; k < matr.GetLength(2); k++)
            {
                matr[k, i, j] += count;
                count++;
            }
        }
    }
}


int[,,] newmatrix = new int[2, 2, 2];
FillArray(newmatrix);
PrintArray(newmatrix);


