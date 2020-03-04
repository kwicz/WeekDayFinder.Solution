using System;

namespace WeekdayFinder.Models
{
  public class NewDateTime
  {

    public static DateTime DateInstance { get; set; }

    public NewDateTime(DateTime dateInstance)
    {
      DateInstance = dateInstance;
    }


    public System.DayOfWeek FindDayOfWeek()
    {
      System.DayOfWeek day = DateInstance.DayOfWeek;
      return day;
    }
  }

}