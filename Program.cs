/*
Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

456 -> 5
782 -> 8
918 -> 1
*/

Console.Clear();
Console.WriteLine ("введите число от 100 до 999"); 
int Number = Convert.ToInt32(Console.ReadLine());  
if (Number > 999)
{
    Console.WriteLine($"число {Number} больше 999");
}
else if (Number < 100)
{
    Console.WriteLine($"число {Number} меньше 100");
}
else
{
Console.WriteLine(Number); 
int SecondFigure = (Number / 10) % 10; 
Console.WriteLine($"вторая цифра числа {Number} это {SecondFigure}");
}
