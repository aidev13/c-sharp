﻿Random number = new();
string call = (number.Next(1,3) == 1) ? "tails" : "heads";

Console.WriteLine(call);
