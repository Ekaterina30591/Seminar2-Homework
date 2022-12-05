// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
/*
int CutNumber(int num)
{
    int des = num / 10;
  
    int result = des % 10;
    return result;
}

Console.Write("Введите трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
int newNumber = CutNumber(number);
Console.WriteLine($"Вторая цифра из числа {number}: {newNumber} ");
*/

// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
/*
int CutNum(int num)
{
while(num > 999)
{
    num = num / 10;
}
int result = num % 10;
int none = -1;

if (num > 99)
{
    return result;
}
else
{
    return none;
}
}
Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int thirdNumber = CutNum(number);

if (thirdNumber == -1)
{
    Console.WriteLine("Третьей цифры нет ");
}
else
{
    Console.WriteLine($"Третья цифра из числа {number}: {thirdNumber} ");
}
*/

//Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

bool WeekEnd(int num)
{
    if (num == 6 || num == 7)
    return true;
    else
    return false;
}
Console.Write("Введите цифру: ");
int day = Convert.ToInt32(Console.ReadLine());
bool result = WeekEnd(day);
Console.WriteLine(result);
