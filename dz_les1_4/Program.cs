double a, b, c, max;
Console.WriteLine("Введите 3 числа через пробел!");
Console.Write("a b c: ");
var s = Console.ReadLine().Split(" ");
a = Convert.ToDouble(s[0]);
b = Convert.ToDouble(s[1]);
c = Convert.ToDouble(s[2]);
max = Math.Max(a, Math.Max(b, c));
Console.WriteLine("Максимальное число: "+ max);