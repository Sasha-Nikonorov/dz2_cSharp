Console.WriteLine("Пожалуйста, введите целое число");
int numberA = int.Parse(Console.ReadLine()!);

if (numberA > 1000)
{
    Console.WriteLine("введите 3х значное число");
    return;
}

int numberB = numberA % 100;
int numberC = numberB / 10;

Console.WriteLine("Вторая цифра введенного числа " + numberC);
