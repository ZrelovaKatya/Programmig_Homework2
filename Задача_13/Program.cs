/* Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6*/

Console.WriteLine ("Введите число: ");
int inputNumber = Convert.ToInt32(Console.ReadLine());
int count = 1;
int number = 10;

while (inputNumber > 99)
{
    if (inputNumber/count < 1000)
    {
        int result = inputNumber/count % 10;
        Console.WriteLine (result);
        break;
    }
    count = count * number;
}

if (inputNumber < 100 )
    {
        Console.WriteLine ("Третьей цифры нет");
    }

