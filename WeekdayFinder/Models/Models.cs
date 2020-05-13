using System;

namespace Weekday.Models
{
  public class Project
  {
    public DateTime UserDate {get;set;}
    
    public Project(Int32 year, Int32 month, Int32 day)
    {
      DateTime userDate = new DateTime(year, month, day);  
      UserDate = userDate;
    }

    public DayOfWeek GetWeekday()
    {
      return UserDate.DayOfWeek;
    }

  }
}

