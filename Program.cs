Random random = new();

int daysLeft = random.Next(12);
// int daysLeft = 0;
int discountPerctage = 0;

if ((daysLeft >= 5) && (daysLeft <= 10))
{
   Console.WriteLine("Your subscription will expire soon. Renew now!");
}
else
{
   Console.WriteLine("");
};

if (daysLeft < 5)
{

   if (daysLeft == 1)
   {
      discountPerctage = 20;
      Console.WriteLine($"Your subscription expires within a day! \nRenew now and save {discountPerctage}%!");
   }
   else if (daysLeft == 0)
   {
      Console.WriteLine("Your subscription has expired.");
   }else

   {
      discountPerctage = 10;
      Console.WriteLine($"Your subscription expires in {daysLeft} days. \nRenew now and save {discountPerctage}%!");
   }

}

Console.WriteLine($@"
    || Days Left: {daysLeft} ||      ");