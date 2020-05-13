using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Weekday.Models;

namespace Weekday.Models
{
  [TestClass]
  public class ProjectTests
  {
    [TestMethod]
    public void Project_GetWeekday_Weekday()
    {
      Project newDate = new Project(1992, 11, 11);
      DayOfWeek weekday = newDate.GetWeekday();

      DateTime compDate = new DateTime(1992, 11, 11);
      Assert.AreEqual(compDate.DayOfWeek, weekday);
    }
  }  
}
