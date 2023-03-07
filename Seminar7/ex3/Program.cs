// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int rows = ReadString("Введите количество строк: ");
int column = ReadString("Введите количество столбцов: ");
int[,] matrix = InputMatrix(rows, column);
OutputMatrix(matrix);
SearchAverage(matrix);


int ReadString(string massege)
{
    Console.Write(massege);
    int readLine = Convert.ToInt32(Console.ReadLine());
    return readLine;
}

//Заполнение матрицы рандомными вещественными числами
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

//Вывод заполненного массива
void OutputMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i, j] + " ");
        }
        Console.WriteLine();
    }
}

void SearchAverage(int[,] matrix)
{
    for (int i = 0; i < column; i++)
    {
        int summ = 0;
        for (int j = 0; j < rows; j++)
        {
            summ = summ + matrix[j, i];   
        }
        Console.Write($"{i} столб: сумма = {summ}, среднее = {summ / matrix.GetLength(1)}");
        Console.WriteLine();
    }
}
