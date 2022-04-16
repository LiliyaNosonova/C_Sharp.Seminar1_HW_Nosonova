// Задача 2: Напишите программу, 
// которая принимает на вход три числа и выдаёт максимальное из этих чисел

int a = 15;
int b = 18;
int c = 10;

int max = a;

if (b > max)
{
    max = b;
}

if (c > max)
{
    max = c;
}

System.Console.WriteLine(max);