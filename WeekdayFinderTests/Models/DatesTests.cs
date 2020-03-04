using Microsoft.VisualStudio.TestTools.UnitTesting;
using WeekdayFinder.Models;
using System;

namespace WeekdayFinder.Tests
{
  [TestClass]
  public class WeekdayFinder
  {
    [TestMethod]
    public void DateTimeConstructor_CreatesNewInstance_DateTime()
    { 
      // Arrange
      int month = 12;
      int day = 25;
      int year = 2010;
      DateTime dateValue = new DateTime(year, month, day);
      NewDateTime newDateTime = new NewDateTime(dateValue);

      // Act

      // Assert
      Assert.AreEqual(typeof(NewDateTime), newDateTime.GetType());
    }

    [TestMethod]
    public void FindDayOfWeek_CheckDateForDay_Saturday()
    {
      // Arrange
      int month = 12;
      int day = 25;
      int year = 2010;
      DateTime dateValue = new DateTime(year, month, day);
      NewDateTime newDateTime = new NewDateTime(dateValue);

      // Act
      System.DayOfWeek actualResponse = newDateTime.FindDayOfWeek();
      System.DayOfWeek expectedResponse = dateValue.DayOfWeek;

      // Assert
      Assert.AreEqual(expectedResponse, actualResponse);
    }
  }
}