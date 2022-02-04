// Даны два числа. Показать большее и меньшее число.
int a = new Random().Next(1, 10);
int b = new Random().Next(1, 10);
Console.WriteLine(a);
Console.WriteLine(b);
if (a > b)
{
    Console.Write("Это число больше: ");
    Console.Write(a);
    Console.WriteLine();
    Console.Write("Это число меньше: ");
    Console.Write(b);
}
else
{
    Console.Write("Это число больше: ");
    Console.Write(b);
    Console.WriteLine();
    Console.Write("Это число меньше: ");
    Console.Write(a);
}

// Найти максимальное из трех чисел.

int Max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if (arg2 > result) result = arg2;
    if (arg3 > result) result = arg3;
    return result;
}

int[] array = {11, 211, 31};

int result = Max(array[0], array[1], array[2]);


Console.WriteLine(result);
