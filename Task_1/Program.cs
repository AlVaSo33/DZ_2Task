//Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа. Через строку решать нельзя.
//456 -> 5
//782 -> 8
//918 -> 1
Console.WriteLine("Введите трехзначное число: ");
int num = int.Parse(Console.ReadLine()!);
if (num > 99 && num <= 999)
{
    int secondDigit = (num / 10) % 10;
    int result = secondDigit;
    Console.WriteLine("Вторая цифра введенного числа: " + secondDigit);

}
else
{
    Console.WriteLine("ошибка ввода. Введите трехзначное число!");
}

