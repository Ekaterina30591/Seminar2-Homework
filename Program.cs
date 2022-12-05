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