// Задача №17.
// Напишите программу, которая принимает на вход
// координаты тоски (Х и Y), причём
// Х не = 0 и Y не =0 и выдаёт номер четверти
// плоскости, в которой находится точка.

Console.WriteLine("Введите число: ");
int x = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число: ");
int y = int.Parse(Console.ReadLine());

if (x > 0 && y > 0)
{
    Console.WriteLine("1");
}
else if(x < 0 && y > 0)
{
    Console.WriteLine("2");
}
else if(x < 0 && y < 0)
{
    Console.WriteLine("3");
}
else 
{
    Console.WriteLine("4");
}
