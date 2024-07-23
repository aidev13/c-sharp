
// Declare and initialize the string array
string[] myStrings = new string[2] { "I like pizza. I like roast chicken. I like salad", "I like all three of the menu choices" };

// Outer loop to process each string element in the array
foreach (string myString in myStrings)
{
   // Get the location of the first period character in the string
   int periodLocation = myString.IndexOf(".");

   // Inner loop to extract and display each sentence
   string remainingString = myString;
   while (periodLocation != -1)
   {
      // Extract the sentence without the period
      string sentence = remainingString.Substring(0, periodLocation).TrimStart();

      // Display the sentence
      Console.WriteLine(sentence);

      // Remove the processed sentence from the remaining string
      remainingString = remainingString.Remove(0, periodLocation + 1);

      // Get the location of the next period character in the remaining string
      periodLocation = remainingString.IndexOf(".");
   }

   // If there are no periods left, display the remaining part of the string
   if (!string.IsNullOrWhiteSpace(remainingString))
   {
      Console.WriteLine(remainingString.TrimStart());
   }

}