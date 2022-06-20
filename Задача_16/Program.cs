/* Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.
5, 25 -> да
-4, 16 -> да
25, 5 -> да
8,9 -> нет */

Console.WriteLine ("Введите первое число: ");
int inputNumber1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("Введите второе число: ");
int inputNumber2 = Convert.ToInt32(Console.ReadLine());

if (inputNumber1 == inputNumber2/inputNumber1 || inputNumber2 == inputNumber1/inputNumber2)
{
    Console.WriteLine ("Да"); 
}
else
{
    Console.WriteLine ("Нет"); 
}