using System;
using Weekday.Models;

namespace Weekday.Models
{
  public class Program
  {
    
    public static void Main()
    {
      Project UserDate;
      repeat:
      try {
        Console.WriteLine("Enter a Date of a Month: ");
        Int32 day = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter a Month (0-11): ");
        Int32 month = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter a Year: ");
        Int32 year = int.Parse(Console.ReadLine());
        UserDate = new Project(year, month, day);
      }
      catch (Exception ex) 
      {
        Console.WriteLine("You suck. Give me a real date.");
        Console.WriteLine("Message {0}", ex.Message);
        goto repeat;
      }
      Console.WriteLine("The day of the week your date was: " + UserDate.GetWeekday());
    }
  }
}

