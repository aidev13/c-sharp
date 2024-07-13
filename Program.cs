string[] fraudIDs = {"b123", "c84888", "b548", "564", "bs88", "asd477", "bre54"};

foreach (string fraudID in fraudIDs)
{
   if (fraudID.StartsWith("b")){
      Console.WriteLine(fraudID);
   }
}