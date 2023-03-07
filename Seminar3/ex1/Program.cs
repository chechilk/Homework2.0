// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.Write("Введите 5ти значное число:\t");
int number = Convert.ToInt32(Console.ReadLine());

var first = number / 10000;
var second = number / 1000 % 10;
var first_end = number % 10;
var second_end = number % 100 / 10;

if (first == first_end && second == second_end)
{
    Console.WriteLine("Число является палиндромом");
} 
else
    Console.WriteLine("Число НЕ является палиндромом");