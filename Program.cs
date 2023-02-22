// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

int[,] FillArray(int[,] matr, int lBound, int hBound)           //  работа с матрицей - наполнение случайными целыми числами в заданном диапазоне
{
    for (int i = 0; i < matr.GetLength(0); i++)
        for (int j = 0; j < matr.GetLength(1); j++)
            matr[i, j] = new Random().Next(lBound, hBound);
    return matr;
}

int[,] CompMatr(int[,] matr1, int[,] matr2, int[,] res)         //  работа с матрицей - перемножение двух матриц c записью результата в третью
{
    for (int i = 0; i < res.GetLength(0); i++)                  //  цикл по строкам
        for (int j = 0; j < res.GetLength(1); j++)              //  цикл по столбцам
            for (int k = 0; k < matr1.GetLength(1); k++)              //  цикл по столбцам
                res[i,j] += matr1[i,k] * matr2[k,j];            //  посчитать произведение i-й строки первой матрицы на j-ю строку второй матрицы
    return res;                                                 //  возврат результата
}

void PrintArray(int[,] matr)                                    //  форматированный вывод матрицы в консоль
{
    for (int i = 0; i < matr.GetLength(0); i++)
        {
            for (int j = 0; j < matr.GetLength(1); j++)
                Console.Write("\t" + matr[i, j]);
            Console.WriteLine();    
        }        
}

Console.Clear();				                                //  очистка консоли
Console.WriteLine("Введите размерность по вертикали m: ");	    //  запрос размерности матрицы по вертикали
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите размерность по горизонтали n: ");	//  запрос размерности матрицы по вертикали
int n = Convert.ToInt32(Console.ReadLine());

int[,] matrix1 = new int[m, n];                                 //  первая матрица
FillArray(matrix1, 1, 100);                                     //  наполнение первой случайными целыми числами в заданном диапазоне (от 1 до 100)
Console.WriteLine("\nПервая матрица:");
PrintArray(matrix1);                                            //  вывод первой матрицы в консоль

int[,] matrix2 = new int[n, m];                                 //  вторая матрица (размерность, обратная размерности первой матрицы)
FillArray(matrix2, 1, 100);                                     //  наполнение второй случайными целыми числами в заданном диапазоне (от 1 до 100)
Console.WriteLine("\nВторая матрица:");
PrintArray(matrix2);                                            //  вывод второй матрицы в консоль

int[,] resMatrix = new int[m, m];                               //  третья (результирующая) матрица
CompMatr(matrix1, matrix2, resMatrix);                          //  перемножение матриц
Console.WriteLine("\nРезультат перемножения матриц:");
PrintArray(resMatrix);                                          //  вывод третьей (результирующей) матрицы в консоль