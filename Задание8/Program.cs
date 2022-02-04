// Показать четные числа от 1 до N.
int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };

int n = array.Length;

int index = 0;

while (index < n)
{
    if (array[index] % 2 == 0)
    {
        Console.WriteLine(array[index]);
    }    
    index++;
}