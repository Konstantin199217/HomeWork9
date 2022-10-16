// Задача 66: Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int ReadData(string msg)
{
    Console.Write(msg);
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
}

int M = ReadData("Введите число M: ");
int N = ReadData("Введите число N: ");

int Sum(int x, int y)
{
    if (x>=y)
    {
        return x;
    }
    return y + Sum(x,y-1);
}

Console.WriteLine(Sum(M,N));