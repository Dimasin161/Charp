/* 10. Напишите программу, которая принимает на вход трехзначное число и на выходе показывает вторую цыфру этого числа.
456 -> 5
782 -> 8
918 -> 1
*/

System.Console.WriteLine("Введите трехзначное число:  ");
int number = Convert.ToInt32(Console.ReadLine());
if (number < 100 || number > 1000) 
{
   System.Console.WriteLine("ЧИтай условие!");
}
else
{

int result = number / 10 % 10;
System.Console.WriteLine(result);
}