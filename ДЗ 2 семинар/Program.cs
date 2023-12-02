//1 задача.
// Console.WriteLine((int.Parse(Console.ReadLine()!) % 161 == 0) ? "Число кратно одновременно 7 и 23." : "Число НЕ кратно одновременно 7 и 23.");


// 2 задача
// using System;
// class Program
// {
//     static void Main()
//     {
//         Console.WriteLine("Введите координаты точки (X и Y):");

//         // Ввод координат с клавиатуры
//         Console.Write("Введите X: ");
//         double x = Convert.ToDouble(Console.ReadLine());

//         Console.Write("Введите Y: ");
//         double y = Convert.ToDouble(Console.ReadLine());

//         // Проверка условия X ≠ 0 и Y ≠ 0
//         if (x == 0 || y == 0)
//         {
//             Console.WriteLine("Ошибка: X и Y должны быть не равны нулю.");
//         }
//         else
//         {
//             // Определение четверти
//             int quadrant = DetermineQuadrant(x, y);

//             // Вывод результата
//             Console.WriteLine($"Точка находится в {quadrant} четверти.");
//         }
//     }

//     // Метод для определения номера координатной четверти
//     static int DetermineQuadrant(double x, double y)
//     {
//         if (x > 0 && y > 0)
//         {
//             return 1;
//         }
//         else if (x < 0 && y > 0)
//         {
//             return 2;
//         }
//         else if (x < 0 && y < 0)
//         {
//             return 3;
//         }
//         else
//         {
//             return 4;
//         }
//     }
// }





//3 задача
// Console.Write("Введите число от 10 до 99: ");
// int number = int.Parse(Console.ReadLine()!);
// while (number < 10 || number > 99)
// {
//     Console.Write("Вы ввели неверное число!\nВведите число от 10 до 99: ");
//     number = int.Parse(Console.ReadLine()!);
// }
// int firstNumber = number / 10;
// int secondNumber = number % 10;
// if (firstNumber > secondNumber)
// {
//     Console.WriteLine("Наибольшая цифра этого числа: " + firstNumber);
// }
// else
// {
//     Console.WriteLine("Наибольшая цифра этого числа: " + secondNumber);
// }



// 4 задача
//Console.Write("Введите любое натуральное число: ");
// int number = int.Parse(Console.ReadLine()!);
// int i = 0;
// while (i <= number)
// {
//     Console.Write($"{i},");
//     i++;
// }