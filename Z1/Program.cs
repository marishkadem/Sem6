/* Задача 41: Пользователь вводит с клавиатуры M чисел. 
Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3
 */

int[] FillArray(int length)
{
    Console.WriteLine($"\nВведите {length} чисел:\n");
    var array = new int[length];
    for (var i = 0; i < array.Length; i++)
    {
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    return array;
}

void PrintArray(int[] a)
{
    Console.WriteLine("\nВведены числа: \n");
    
    for (int i = 0; i < a.Length - 1; i++)
    {
        Console.Write($"{a[i]}, ");
    }
    Console.Write($"{a[a.Length - 1]}");
}

int PosNumber(int[] numbers)
{
    int n = 0;
    for (int i = 0; i < numbers.Length; i++)
    {
        if (numbers[i] > 0)
        {
            n++;
        }
    }
    return n;
}

int[] a = FillArray(6);
PrintArray(a);
Console.WriteLine($"\n\nВведено {PosNumber(a)} положительных чисел");


