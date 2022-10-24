//Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа. Через строку решать нельзя.
//456 -> 5
//782 -> 8
//918 -> 1

int GetSecondDigit(int num)
{
    int secondDigit = (num / 10) % 10;
    return (secondDigit);
}

Console.WriteLine("Введите трехзначное число: ");
int num = int.Parse(Console.ReadLine()!);

int secondDigit = GetSecondDigit(num);

Console.WriteLine("Вторая цифра введенного числа: " + secondDigit);

