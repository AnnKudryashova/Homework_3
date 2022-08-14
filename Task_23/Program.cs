// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

Console.WriteLine("Введите положительное число");
int x = int.Parse(Console.ReadLine());

if (x <=0) 
{
    Console.WriteLine("Введено неверное значение");
}

int count = 1;

while (count <= x)
{
    double cube = Math.Pow(count,3);
    count++;
    Console.WriteLine(cube);
}