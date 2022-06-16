// Задача 4: Напишите программу, которая принимает на вход цифру,
// обозначающую день недели, и проверяет, является ли этот день выходным.
int prompt(string message)
{
    Console.WriteLine(message);
    string param = Console.ReadLine();
    return int.Parse(param);
}
int num = prompt("Enter a weekday number, please: ");

if (num < 1 || num > 7)
{
    Console.WriteLine("Not a weekday number!");
}
else
{
    bool weekend = isWeekend(num);    
    if (weekend)
    {
        Console.WriteLine($"{num} is a weekend.");
    }
    else
    {
        Console.WriteLine($"{num} is not a weekend.");
    }
}

bool isWeekend(int num)
{
    if (num > 5 && num < 8)
    {
        return true;
    }
    else
    {
        return false;
    }
}
