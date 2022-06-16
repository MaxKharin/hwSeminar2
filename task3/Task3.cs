// Задача 3: Напишите программу, которая выводит третью цифру заданного числа
// или сообщает, что третьей цифры нет.
int prompt(string message)
{
    System.Console.WriteLine(message);
    string param = Console.ReadLine();
    return int.Parse(param);
}
int num = prompt("Enter a number, please: ");

int thirdDigit = findThirdDigit(num);
if (thirdDigit == -1) 
{
    Console.WriteLine("There is no third digit");    
}
else
{
    Console.WriteLine($"Third digit is {thirdDigit}");    
}

int findThirdDigit(int num)
{
    if (num < 0) 
    {
        num *= -1;
    }

    if (num < 100)
    {
        return -1;
    }
    else
    { 
        while (num > 999) 
        { 
            num /= 10;
        } 
        return num % 10;
    }
}