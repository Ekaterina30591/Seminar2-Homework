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
    Console.WriteLine("Третьего числа нет ");
}
else
{
    Console.WriteLine($"Третья цифра из числа {number}: {thirdNumber} ");
}