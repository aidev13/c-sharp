﻿//Decision logic challenge

string permission = "Manager";
int level = 21;

if (permission.Contains("Admin"))
{
   if (level > 55)
   Console.WriteLine("Super User.");
   else
   Console.WriteLine("Admin user");
}
 else if (permission.Contains("Manager"))
{
   if(level >= 20)
   Console.WriteLine("Contact admins.");
   else
   Console.WriteLine("Access denied");
}
else 
Console.WriteLine("You do not have the rights/");