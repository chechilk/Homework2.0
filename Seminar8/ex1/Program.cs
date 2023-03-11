// Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4


int rows = ReadString("Введите количество строк: ");
int column = ReadString("Введите количество столбцов: ");
int[,] matrix = InputMatrix(rows, column);
OutputMatrix(matrix);
int[,] resultMatrix = ChangeNumbers(matrix);
OutputResultMatrix(resultMatrix);

/// <summary>
/// Чтение информации с консоли
/// </summary>
/// <param name="text">Введённый текст с консоли</param>
/// <returns>Возврат строки с консоли</returns>
int ReadString(string text)
{
    Console.Write(text);
    int readLine = Convert.ToInt32(Console.ReadLine());
    return readLine;
}

/// <summary>
/// Заполнение массива рандомными числами от 1 до 10
/// </summary>
/// <param name="rows">Количество строк</param>
/// <param name="column">Количество столбцов</param>
/// <returns>Возврат заполненного массива рандомными значениями</returns>
int[,] InputMatrix(int rows, int column)
{
    int[,] matrix = new int[rows, column];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < column; j++)
        {
            matrix[i, j] = new Random().Next(1, 11);
        }
    }
    return matrix;
}
/// <summary>
///  Вывод заполненного массива в консоль до перестановки
/// </summary>
/// <param name="matrix">Заполненный массив</param>
void OutputMatrix(int[,] matrix)
{
    Console.WriteLine("Массив ДО перестановки: ");
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i, j] + " ");
        }
        Console.WriteLine();
    }
}

/// <summary>
/// Перемещение минимального значения массива в конец
/// </summary>
/// <param name="matrix">На вход подаётся изначальный массив</param>
/// <returns>Возвращает изменённый массив </returns>
int[,] ChangeNumbers(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1) - 1; j++)
        {
            if (matrix[i, j] < matrix[i, j + 1])
            {
                int temp = 0;
                temp = matrix[i, j];
                matrix[i, j] = matrix[i, j + 1];
                matrix[i, j + 1] = temp;
            }

        }
    }
    return matrix;
}

/// <summary>
/// Вывод массива с упорядоченными элементами по убыванию
/// </summary>
/// <param name="resultMatrix">Вывод изменённого массива</param>
void OutputResultMatrix(int[,] resultMatrix)
{
    Console.WriteLine("Массив после перестановки: ");
    for (int i = 0; i < resultMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < resultMatrix.GetLength(1); j++)
        {
            Console.Write(resultMatrix[i, j] + " ");
        }
        Console.WriteLine();
    }
}