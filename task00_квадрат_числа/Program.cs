/*
0. Напишите программу, которая на вход приимает число и 
выдает его квадрат (число умноженное на само себя)
*/

System.Console.WriteLine("Введите число: "); // cw - быстрый вызов консоль Console.WriteLine       
int userNumber = Convert.ToInt32(Console.ReadLine()); /*В Програмировании строчки читают с права на лево  */

int result = userNumber * userNumber;

System.Console.WriteLine(result);
System.Console.WriteLine(userNumber * userNumber);