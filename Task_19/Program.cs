// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

Console.WriteLine("Введите пятизначное число");

int number = Convert.ToInt32(Console.ReadLine());

if (number < 0)
{
    number = number*(-1);
}

if (number > 99999 || number < 10000)
{
    Console.WriteLine("Введено неверное значение, число не пятизначное");
    return;
}

string numberArray = Convert.ToString(number);

if (numberArray[0] == numberArray[4] && numberArray[1] == numberArray[3])
{
    Console.WriteLine("Это палиндром");
}
else Console.WriteLine("Это не палиндром");