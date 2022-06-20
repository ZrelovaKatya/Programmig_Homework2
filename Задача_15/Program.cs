/* Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
6 -> да
7 -> да
1 -> нет */

Console.WriteLine ("Введите цифру: ");
int inputNumber = Convert.ToInt32(Console.ReadLine());

if (inputNumber > 0 && inputNumber < 8)
{
    if (inputNumber == 6 || inputNumber == 7)
    {
       Console.WriteLine ("Выходной день"); 
    }
    else
    {
       Console.WriteLine ("Будний день"); 
    }
}
else
{
    Console.WriteLine ("Цифра не обозначает день недели"); 
}