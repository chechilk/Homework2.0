// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

int rows = 2;
int column = 2;
int width = 2;

int[,,] matrix = InputMatrix(rows, column, width);
OutputMatrix(matrix);

/// <summary>
/// Заполнение трёхмерного массива рандомными двухзначными числами
/// </summary>
/// <param name="rows">Строки</param>
/// <param name="column">Столбцы</param>
/// <param name="width">Ширина?</param>
/// <returns></returns>
int[,,] InputMatrix(int rows, int column, int width)
{
    int[,,] matrix = new int[rows, column, width];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < column; j++)
        {
            for (int k = 0; k < width; k++)
            {
                matrix[i, j, k] = new Random().Next(10, 51);
            }
        }
    }
    return matrix;
}

/// <summary>
///  Вывод в консоль трехёмерно массива и его индексы
/// </summary>
/// <param name="matrix">Заполненный массив</param>
void OutputMatrix(int[,,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                Console.Write($"{matrix[i, j, k]} индексы ({i},{j},{k}) ");
            }
            Console.WriteLine();
        }
    }
}