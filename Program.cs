// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, Dolly!");

// Задача 1: Напишите программу, которая принимает на вход число и проверяет, 
// кратно ли оно одновременно 7 и 23.

// Console.Write("Введите число number: ");
// int number = Convert.ToInt32(Console.ReadLine());

// if (number % 7 == 0 && number % 23 == 0)
// {
// Console.Write($"числа 7 и 23 кратны {number}");
// }
// else
// {
//    Console.Write($"числа 7 и 23 не кратны {number}");
// }

// ЗАДАЧА №2 к уроку 2
// Напишите программу, которая принимает на вход координаты точки 
// (X и Y), причём X ≠ 0 и Y ≠ 0 и выдаёт номер координатной четверти плоскости, 
// в которой находится эта точка.

// Console.Write("Введите координату X: ");
// int coordinata_X = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите координату Y: ");
// int coordinata_Y = Convert.ToInt32(Console.ReadLine());
// if (coordinata_X > 0 && coordinata_Y > 0)
// {
//    Console.Write("Точка находится в первой четверти оси координат");
// }
// if (coordinata_X < 0 && coordinata_Y > 0)
// {
//    Console.Write("Точка находится во второй четверти оси координат");
// }
// if (coordinata_X < 0 && coordinata_Y < 0)
// {
//    Console.Write("Точка находится в третьей четверти оси координат");
// }
// else
// {
//    Console.Write("Точка находится в четвёртой четверти оси координат");
// }

// ЗАДАЧА №3 к уроку 2
// Напишите программу, которая принимает на вход целое число из отрезка [10, 99]
// и показывает наибольшую цифру числа.

// Console.Write("Введите число number: ");
// int number = Convert.ToInt32(Console.ReadLine());
// int numberMin = 10;
// int numberMax = 99;
// int firstElement = 0;
// int secondElement = 0;
// if (number < numberMin || number > numberMax)
// {
// Console.Write("Число вне диапазона 10 - 99");
// }
// else
// {
// firstElement = number % 10;
// secondElement = number / 10;
// }
// if (firstElement >= secondElement)
// {
//    Console.Write(firstElement);
// }
// else{
//    Console.Write(secondElement);
// }

// ЗАДАЧА №4 к уроку 2
// Напишите программу, которая на вход принимает натуральное число N, а на выходе
// показывает его цифры через запятую.

Console.Write("Введите натуральное число number: ");
int number = Convert.ToInt32(Console.ReadLine());
int num1;

while (number >= 10)
{
num1 = number % 10;
Console.Write($"{num1}, ");
 number = number / 10;
}
if (number < 10)
{
   num1 = number;
   Console.WriteLine($"{num1}");
}

