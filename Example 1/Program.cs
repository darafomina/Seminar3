// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// 14212 -> нет

// 12821 -> да

// 23432 -> да

Console.WriteLine("Введите число ");
string? numberString = Console.ReadLine();
int number = int.Parse(numberString!);

if (number > 99999 || number < 10000)
{
 Console.WriteLine("Введите положительное пятизначное число");
 return;
}

int i0 = number.ToString()[0];
int i1 = number.ToString()[1];
int i3 = number.ToString()[3];
int i4 = number.ToString()[4];

if(i0 == i4 && i1 == i3 )
    Console.WriteLine("ДА");
else
    Console.WriteLine("НЕТ");