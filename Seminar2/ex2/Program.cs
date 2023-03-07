// Напишите программу, которая выводит третью цифру заданного семизначного числа или сообщает, 
// что третьей цифры нет.
// 78 -> третьей цифры нет
// 3267900 -> 6

Console.Write("Введите число = ");
int number = Convert.ToInt32(Console.ReadLine());
if (number / 100 == 0)
{
    Console.WriteLine("Третьей цифры нет!");
}
else
{
    int x1 = number / 10000;
    int y1 = x1 / 10 * 10;
    int x2 = number % 1000 / 100;
    Console.WriteLine($"Третья цифра числа c левой стороны {number} = {x1 - y1}, с правой стороны = {x2}");
}

// Просто решила попробовать сделать вывод всех третьих чисел от 1 до 7 значных. Возможно, это можно сделать покороче,
// но не дошло пока что до меня)

// Console.Write("Введите число = ");
// int number = Convert.ToInt32(Console.ReadLine());
// int search = number;
// int left = 0, i = 0, right = 0;
// int div = 1;

// while (search > 0)
// {
//     search = search / 10;
//     i++;
// }
// if (i < 3)
// {
//     Console.WriteLine("Третьей цифры нет!");
// }
// else if (i > 2 && i < 8)
// {
//     for (int j = 0; j < (i - 3); j++)
//     {
//         div = div * 10;
//     }
//     left = number / div % 10;
//     right = number % 1000 / 100;
//     Console.WriteLine($"Третья цифра числа {number} cлева = {left}, справа {right}");
// }
// else if (i > 7)
// {
//     Console.WriteLine("Число больше 7-ми!");
// }