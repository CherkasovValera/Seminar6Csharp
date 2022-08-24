//Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
//0, 7, 8, -2, -2 -> 2
//1, -7, 567, 89, 223-> 3

// int[] CreateArray()
// {
//     Console.WriteLine("Введите количество элементов массива");
//     int size = Convert.ToInt32(Console.ReadLine());
//     int[] RandomArray = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         Console.WriteLine($"Введите {i + 1} элемент массива");
//         RandomArray[i] = Convert.ToInt32(Console.ReadLine());
//     }
//     return RandomArray;
// }
// void ShowArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write(array[i] + " ");
//     }
//     int sum = 0;
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (array[i] > 0)
//             sum++;
//     }
//     Console.WriteLine();
//     Console.WriteLine("Количество элементов массива которые больше ноля =  " + sum);
// }
// Console.Clear();
// int[] myArray = CreateArray();
// ShowArray(myArray);


//Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
//заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
//b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

// Console.Clear();
// Console.Write("Для уавнения y=k1*x+b1 введите переменную k1:  ");
// double k1 = double.Parse(Console.ReadLine());
// Console.Write("Для уавнения y=k1*x+b1 введите переменную b1:  ");
// double b1 = double.Parse(Console.ReadLine());
// Console.Write("Для уавнения y=k2*x+b2 введите переменную k2:  ");
// double k2 = double.Parse(Console.ReadLine());
// Console.Write("Для уавнения y=k2*x+b2 введите переменную b2:  ");
// double b2 = double.Parse(Console.ReadLine());
// if (k1 != k2)
// {
//     Console.WriteLine($"Точка пересечения прямых О ({(b2 - b1) / (k1 - k2):f2};{k1 * (b2 - b1) / (k1 - k2) + b1:f2})");
// }
// else
// {
//     Console.WriteLine("Нет решения!!!");
// }
