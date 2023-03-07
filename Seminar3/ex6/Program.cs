// Назовём число «интересным», если его произведение цифр делится на их сумму. 
// Напишите программу, которая заполняет массив на 10 «интересных» случайных целых чисел от 10 до 1000. 
// (каждый эл-т массива – сгенерирован случайно)
// [591, 532, 189, 523, 333, 546, 527, 275, 456, 264]
// 591: (5*9*1)/(5+9+1)=45/15=3


int[] array = new int[10];
Console.WriteLine($"Массив из 10ти интересных чисел с уловием");

for (int i = 0; i < 10; i++)
{
    while (true)
    {
        int number = new Random().Next(10, 1001);
        if (GetMulti(number) == 0) continue;
        if (GetMulti(number) % GetSumm(number) == 0)
        {
            array[i] = number;
            Console.WriteLine($"Число массива: {number} \t произведение {GetMulti(number)} \t сумма {GetSumm(number)} \t разность {GetMulti(number) / GetSumm(number)}");
            break;
        }

    }
}
Console.WriteLine($"Итоговый массив [{String.Join(";", array)}]");

int GetMulti(int number)
{
    int multi = 1;
    while (number > 0)
    {
        multi = (number % 10) * multi;
        number /= 10;
    }
    return multi;
}

int GetSumm(int number)
{
    int summ = 0;
    while (number > 0)
    {
        summ = (number % 10) + summ;
        number /= 10;
    }
    return summ;
}