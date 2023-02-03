
Console.WriteLine("Введите число");

int number = Convert.ToInt32(Console.ReadLine());

int reminder = number % 2;

if (reminder > 0)
{
    System.Console.WriteLine("нечетное");
}
else 
{
System.Console.WriteLine("четное");
}
