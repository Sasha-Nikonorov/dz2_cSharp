Console.WriteLine("Пожалуйста, введите целое число");
string? numberAString = Console.ReadLine();
int numberA = int.Parse(numberAString!);

int numberB = numberA % 100;
int numberC = numberB / 10;
Console.WriteLine("Вторая цифра введенного числа " + numberC);