Console.WriteLine("Пожалуйста, введите целое число");
int numberA = int.Parse(Console.ReadLine());

if(numberA<=5)
{
    Console.WriteLine("Нет");
}
else if(numberA <= 7)
{
    Console.WriteLine("Да");
}
else
{
    Console.WriteLine("Введите число от 1 до 7");
}
