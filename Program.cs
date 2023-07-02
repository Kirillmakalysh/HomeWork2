// Напишите программу которая выводит случайное число из отрезка (10 99)
// и показывает наибольшую цифру числа.
// int randint = new Random().Next(10, 100);
// int first = randint / 10; // первая цифра
// int second = randint % 10; // вторая цифра
// int max = first;
// if (second > max)
// {
//     max = second;
// }
// Console.WriteLine("Максимальная цифра в числе: " + randint + "- это число " + max);
// Console.WriteLine($"Максимальная цифра в числе {randint} - это {max}");


//напишите программу которая выводит случайное 3х значное число
//и удаляет вторую цифру этого числа.
// int randint = new Random().Next(100, 1000);
// int result = (randint / 100) * 10 + randint % 10;
// Console.WriteLine($"Итоговое число из исла {randint} - это {result}");


//Написать программу которая на вход будет принимать 2 числа и выводить
//является ли второе число кратным первому если нет то программа выводит остаток от деления
// Console.Write("Введите первое число: ");
// int firstnum = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите второе число число: ");
// int secondnum = Convert.ToInt32(Console.ReadLine());
// if (firstnum % secondnum == 0)
// {
//     Console.WriteLine($"Число {firstnum} кратно числу {secondnum}");
// }
// else
// {
//     Console.WriteLine($"Остаток от деления числа {firstnum} на {secondnum} равен {firstnum % secondnum}");
// }


// Напишите программу которая на вход принимает число и проверяет
// кратно ли оно одновременно 7 и 23 

// Console.Write("Введите число: ");
// int num = Convert.ToInt32(Console.ReadLine());
// if (num % 7 == 0 && num % 23 == 0)
// {
//     Console.WriteLine($"Число {num} кратно числу числам 7 и 23");
// }
// else
// {
// Console.WriteLine($"Число {num} делится на число 7 с остатоком {num % 7}");
// Console.WriteLine($"Число {num} делится на число 23 с остатоком {num % 23}");
// }




// 10. Напишите программу которая принимает на вход трехзначное число и на выходе 
// показывает вторую цифру этого числа

// Console.Write("Введите трехзначное число: ");
// int num = Convert.ToInt32(Console.ReadLine());
// int num2 = num / 10 % 10;
// Console.WriteLine(num2);


// Задача 13: Напишите программу, 
// которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет. До 10 символов

// Console.Write("Введите число: "); // до 10 знаков по определению тк интовая переменная выделяет мало памяти. 
// int num = Convert.ToInt32(Console.ReadLine());
// int num2 = num;
// while (num2 > 999)
// {
//     num2 /= 10;
// }
// if (num2 > 100)
// {
//  num2 %= 10;
//  Console.WriteLine($"Третья цифра числа {num} это {num2}");
// }
// else
// {
// Console.WriteLine($"У числа {num} нет третьей цифры");
// }

// Задача 15: Напишите программу, которая принимает на вход цифру,
//  обозначающую день недели, и проверяет, является ли этот день выходным.

// Console.Write("Введите цифру дня недели: "); 
// int num = Convert.ToInt32(Console.ReadLine());
// if (num <= 0 | num >= 8)
// {
//     Console.WriteLine("Введите корректную цифру дня недели: ");    
// }
// else
// {
//     if (num > 5)
//     {
//         Console.WriteLine("Это выходной день");
//     }
//     else
//     {
//         Console.WriteLine("Это будний день");
//     }
// }


