Console.Write("Введите число: ");
int m = int.Parse(Console.ReadLine());
 for (int i = 1; i <= m; i++)
    {
     if (i % 2 == 0) 
      {
       Console.Write(i + " ");
      }
    }