// Назовем число интересным, если в нем разность максимальной и минимальной цифры равняется средней по РАСПОЛОЖЕНИЮ цифре.
// Напишите программу, которая определяет интересное число или нет. 
// Если число интересное, следует вывести – «Число интересное» иначе «Число неинтересное».
// -> 954 - число интересное, средняя цифра - 5, разница: 9 - 4 = 5.
// Средняя цифра - цифра(962-6, 23456 - средняя 4)

int number = new Random().Next(100,1001);
//int number = 23456;
//int number = 954;
Console.WriteLine($"Число: {number}");
int max = 0, y = 0, min = 0, i = 0, j = 0, div = 1;
int average = 0;

SearchchKolvoNumbers(number);
SearchMax(number);
SearchMin(number);
SearchAverage(number);
SearchInterestingNumber(number, max, min, average);

int SearchchKolvoNumbers(int num)
{
    while (num > 0)
    {
        num /= 10;
        i++;
    }
    do
    {
        if (i % 2 == 0)
        {
            Console.Write("Число не подходит для решения!");
            break;
        }
    } while (false);
    return i;
}

int SearchMax(int x)
{
    while (x > 0)
    {
        y = x % 10;
        if (y > max)
        {
            max = y;
        }
        x = x / 10;
    }
    Console.WriteLine($"Максимальная цифра числа {number} = {max}");
    return max;
}

int SearchMin(int x)
{
    min = max;
    while (x > 0)
    {
        y = x % 10;
        if (y <= min)
        {
            min = y;
        }
        x = x / 10;
    }
    Console.WriteLine($"Минимальная цифра числа {number} = {min}");
    return min;
}

int SearchAverage(int x)
{
    j = i / 2;
    while (j > 0)
    {
        div = div * 10;
        j--;
    }
    average = x / div % 10;
    Console.WriteLine($"Средняя по расположению цифра числа {number} = {average}");
    return average;
}

void SearchInterestingNumber(int num, int max_num, int min_num, int aver)
{
    if (max_num - min_num == aver)
    {
        Console.WriteLine($"Число {number} является интересным");
    }
    else 
    Console.WriteLine($"Число {number} является НЕ интересным. Ищем дальше =)");
}


