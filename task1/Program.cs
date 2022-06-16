// Задача 1: Напишите программу, которая принимает на вход трёхзначное число
// и на выходе показывает вторую цифру этого числа.
int Prompt(string message)
{
    System.Console.WriteLine(message);
    string param = Console.ReadLine();
    return int.Parse(param);
}
int num = Prompt("Enter a 3 digit number, please: ");
if (num > 100 && num < 1000)
{
    int result = num / 10 % 10;
    System.Console.WriteLine($"Second digit is: {result}");
}
else
{
    System.Console.WriteLine($"{num} is not a 3 digit number!");
}