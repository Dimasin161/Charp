/* 
13. Напишите программу,которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цыфры нет
32679 -> 6
*/ 
System.Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int result = 0;
for (int i = number; i > 1000; i = i / 10)
{
  result = i % 10; 
   
}
if (number < 100)
{
  System.Console.WriteLine("третьей цифры нет: ");  
}
else
{
  System.Console.WriteLine(result);
}



