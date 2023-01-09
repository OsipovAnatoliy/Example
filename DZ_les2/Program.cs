int num = new Random().Next(100, 1000);
int secondNumber = num / 10 % 10;
Console.WriteLine($"Вторая цифра в числе {num} -> {secondNumber}");
