// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:

// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
//1(строчка) 7 (столбец) -> такого числа в массиве нет


int rows = ReadString("Введите количество строк: ");
int column = ReadString("Введите количество столбцов: ");
int[,] matrix = InputMatrix(rows, column);
OutputMatrix(matrix);
//SearchNumber(matrix);
InputResult();

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

// Поиск числа в матрице 
// void SearchNumber(int[,] matrix)
// {
//     int number = ReadString("Введите искомое число: ");
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             if (matrix[i, j] == number)
//             {
//                 Console.WriteLine($"Число {number} находится в {i} строке {j} столбце");
//             }
//         }
//     }
// }

int SearchPosition(int[,] matrix)
{
    int n = ReadString("Введите номер строки для поиска: ");
    int m = ReadString("Введите номер столбца для поиска: ");
    int k = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (n == i && m == j)
            {
                k++;
                Console.Write($"В позиции {n} строка {m} столбец найдено число {matrix[i, j]}. ");
            }
        }
    }
    return k;
}

void InputResult(){
    int k = SearchPosition(matrix);
    if (k == 0)
    {
        Console.Write($"Элемент в массиве не найден");
    }  else Console.Write($"Элемент в массиве найден");
}