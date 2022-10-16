// Задайте значение N. Напишите программу, которая выведет 
// все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

int ReadData(string msg)
{
    Console.Write(msg);
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
}

int N = ReadData("Введите Ваше число: ");

int Nat(int x)
{
    int result = 0;
    Console.WriteLine(x);
    if (x == 1)
    {
        return 0;
    }
    result = Nat(x-1);
    return result;
}

Console.WriteLine(Nat(N));
