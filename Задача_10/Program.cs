/*Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
456 -> 5
782 -> 8
918 -> 1 */

Console.WriteLine ("Введите число: ");
int inputNumber = Convert.ToInt32(Console.ReadLine());


if (inputNumber > 99 && inputNumber < 1000)
{
    int secondDigit = (inputNumber / 10) % 10;
    Console.WriteLine (secondDigit);
}
else
{
    Console.WriteLine ("Не трехзначное число");
}
