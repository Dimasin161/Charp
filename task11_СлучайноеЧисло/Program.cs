/*
 Напишите программу, которая выводит случайное трехначное число и удаляет вторую цифру этого числа.
 456 -> 46
 782 -> 72
 918 -> 98
*/

int number = new Random().Next(100, 1000);
System.Console.WriteLine(number);
int first = number / 100;
int last = number % 10;
Console.Clear(); // сказали лепить эту команду в каждом уроке
//System.Console.WriteLine(first + "" + last);
System.Console.WriteLine();
int Result = first * 10 + last;
System.Console.WriteLine(Result);



    