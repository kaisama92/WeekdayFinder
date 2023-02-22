using System;

class Program
{
  static void Main()
  {
    try
    {
      Console.WriteLine("Please enter a year");
      string year = Console.ReadLine();
      int longYear = int.Parse(year);
      Console.WriteLine("Please enter a month's numeric equivalent where 1 is January and 12 is December");
      string month = Console.ReadLine();
      int longMonth = int.Parse(month);
      Console.WriteLine("Please enter a valid day number?");
      string day = Console.ReadLine();
      int longDay = int.Parse(day);
      // long l = long.Parse(response);\

      // try
      // {
        
      DateTime nDT = new DateTime(longYear, longMonth, longDay);
      Console.WriteLine(nDT.DayOfWeek);
    }
    catch (Exception ex)
    {
      Console.WriteLine("Message = {0}", ex.Message);
      Program.Main();
    }
  }

  // static void 
}