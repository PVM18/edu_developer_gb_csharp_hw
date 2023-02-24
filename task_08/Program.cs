// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

// 5 -> 2, 4
// 8 -> 2, 4, 6, 8
Console.WriteLine("Введите целое число n ");
int n = Convert.ToInt32(Console.ReadLine());
if (n >= 2)
{
    for (int i = 1; i <= n; i++)
    {
        int ip = i % 2;
        if (ip == 0)
        {
            Console.Write(i);
            Console.Write(" ");
        }
    }
}
else
{
    Console.Write("Введено число меньше 2!!!");
}