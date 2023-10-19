// Задача №17.
// Напишите программу, которая принимает на вход
// координаты тоски (Х и Y), причём
// Х не = 0 и Y не =0 и выдаёт номер четверти
// плоскости, в которой находится точка.

// Console.WriteLine("Введите число: ");
// int x = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите число: ");
// int y = int.Parse(Console.ReadLine());

// if (x > 0 && y > 0)
// {
//     Console.WriteLine("1");
// }
// else if(x < 0 && y > 0)
// {
//     Console.WriteLine("2");
// }
// else if(x < 0 && y < 0)
// {
//     Console.WriteLine("3");
// }
// else 
// {
//     Console.WriteLine("4");
// }

// Задача №18
// Напишите программу, которая по заданному номеручетверти,
// показывает диапазон возможности координат точек в этой четверти (x и y).

// Console.WriteLine("Введите число: ");
// int num = Convert.ToInt32(Console.ReadLine());

// switch (num)
// {
//     case 1:
//         {

//             Console.WriteLine("x<0  y>0");
//             break;
//         }
//     case 2:
//         {

//             Console.WriteLine("x<0  y>0");
//             break;
//         }
//     case 3:
//         {

//             Console.WriteLine("x<0  y<0");
//             break;
//         }
//     case 4:
//         {
//             Console.WriteLine("x>0  y<0");
//             break;
//         }
//         default:
//         {
//             Console.WriteLine("Нет такой четверти");
//             break;
//         }
// }

// // Задача, определить гласную букву алфавита.
// class SwitchCase
// {
//     public static void Main(string[] args)
//     {
//         char ch;
//         Console.WriteLine("Введите букву");
//         ch = Convert.ToChar(Console.ReadLine());

//         switch (Char.ToLowerInvariant(ch))
//         {
//             case 'a':
//             case 'у':
//             case 'о':
//             case 'ы':
//             case 'и':
//             case 'э':
//             case 'я':
//             case 'ю':
//             case 'е':
//             case 'ё':
//                 {
//                     Console.WriteLine("Гласная");
//                     break;

//                 }
//             default:

//                 {
//                     Console.WriteLine("Согласная");
//                     break;
//                 }
//         }
//     }
// }
