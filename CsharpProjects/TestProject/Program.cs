/*
string[] fraudulentOrderIDs = new string[3];

fraudulentOrderIDs[0] = "A123";
fraudulentOrderIDs[1] = "B456";
fraudulentOrderIDs[2] = "C789";
// fraudulentOrderIDs[3] = "D000";
*/


string[] IDs = { "B123", "C234", "A345", "C15", "B177", "G3003", "C235", "B179" };

foreach (string name in IDs)
{
  if (name.StartsWith("B"))
  {
    Console.WriteLine(name);

  }
}