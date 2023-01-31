//Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
//456 -> 5
//782 -> 8
//918 -> 1

Console.Write("Введите трехзначное число: ");
int numTask1 = Convert.ToInt32(Console.ReadLine());
int resultTask1 = -1;
if (numTask1 % 100 == 10)
{
    resultTask1 = (numTask1 / 10) % 10;
}
Console.WriteLine($"Hello, World! {resultTask1}");
