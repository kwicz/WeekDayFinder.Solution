using System;
using WeekdayFinder.Models;

namespace DayOfWeek
{
  public class Program
  {
    public static void Main()
    {
      Console.WriteLine("enter a date and find out what day of the week it was one \n enter a month");
      string stringMonth = Console.ReadLine();
      Console.WriteLine("enter a day");
      string stringDay = Console.ReadLine();
      Console.WriteLine("enter a year");
      string stringYear = Console.ReadLine();
      int month = 0, day = 0,  year = 0;
      try
      {
        month = int.Parse(stringMonth);
        day = int.Parse(stringDay);
        year = int.Parse(stringYear);

      }
      catch (Exception ex)
      {
        Console.WriteLine("Message = {0}", ex.Message);
        Console.WriteLine("Source = {0}", ex.Source);
        Console.WriteLine("StackTrace = {0}", ex.StackTrace);
        Console.WriteLine("TargetSite = {0}", ex.TargetSite);
      }
      DateTime dateTime = new DateTime(year, month, day);
      NewDateTime newDateTime = new NewDateTime(dateTime);
      System.DayOfWeek weekDay = newDateTime.FindDayOfWeek();
      Console.WriteLine("the day of the week your selected day is : " + weekDay);
    }
  }
}