﻿for (int i = 0; i <= 100; i++)
{
   if ((i % 5 == 0) && (i % 3 == 0))
      Console.WriteLine("fizzbuzz");
   else if (i % 5 == 0)
      Console.WriteLine("buzz");
   else if (i % 3 == 0)
      Console.WriteLine("Fizz");
   else Console.WriteLine(i);
}