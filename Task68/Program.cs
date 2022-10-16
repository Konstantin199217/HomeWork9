// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

int ReadData(string msg)
{
    Console.Write(msg);
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
}

int m = ReadData("Введите число m: ");
int n = ReadData("Введите число n: ");

int Aker(int x, int y)
{
    if (x == 0)
    {
        return y + 1;
    }
    if (x > 0 && y == 0)
    {
        return Aker(x - 1, 1);
    }
    return Aker(x - 1, Aker(x, y - 1));
}

Console.WriteLine(Aker(m, n));
