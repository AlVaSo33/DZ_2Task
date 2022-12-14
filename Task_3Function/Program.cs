// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
//6 -> да
//7 -> да
//1 -> нет

Console.WriteLine("Введите число от 1 до 7: ");
int number = int.Parse(Console.ReadLine()!);

if (IsHoliday(number))
{
    if ((number >= 1 && number <= 7))
    {
        if (number == 6 | number == 7) Console.Write("Да. Сегодня выходной");
        else Console.Write("Нет. Сегдня рабочий день");
    }
}
else Console.WriteLine("Ошибка. Введите число от 1 до 7!");
bool IsHoliday(int number)
{
    return (number >= 1 && number <= 7);
}
