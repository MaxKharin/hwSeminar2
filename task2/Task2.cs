// Задача 2: Напишите программу, которая выводит случайное трёхзначное число
// и удаляет вторую цифру этого числа.
int num = new Random().Next(100, 1000);
Console.WriteLine($"Random number is {num}");
int firstDigit = num / 100;
int thirdDigit = num % 10;
System.Console.WriteLine($"Result is {firstDigit}{thirdDigit}");