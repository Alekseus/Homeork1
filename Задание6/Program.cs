// Выяснить является ли число четным.

int a = new Random().Next(1, 50);

if (a % 2 == 0)
{
    Console.Write(a);
    Console.Write(" - четное");
}
else
{
    Console.Write(a);
    Console.Write(" - нечетное");
}